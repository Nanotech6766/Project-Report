using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using foll_backend.Care.Application.Internal.CommandServices;
using foll_backend.Care.Domain.Model.Commands;
using foll_backend.Care.Domain.Model.Entities;
using foll_backend.Care.Domain.Model.ValueObjects;
using foll_backend.Care.Domain.Repositories;
using foll_backend.Shared.Domain.Repositories;
using Moq;
using FluentAssertions;

namespace foll_backend.Tests.Steps;

public class US34_CaregiverQrSteps
{
    private readonly Mock<IPatientRepository> _patientRepositoryMock = new();
    private readonly Mock<foll_backend.Care.Application.OutboundServices.IUserInfoService> _userInfoServiceMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private LinkCaregiverViaQrCommandHandler? _qrHandler;
    private Patient? _patient;
    private long _patientId;
    private long _caregiverId;
    private bool _requestResultSuccessful;
    private string? _errorMessage;

    [Given("un paciente \"([^\"]*)\" registrado en el sistema con ID (\\d+)")]
    public void GivenUnPacienteRegistradoEnElSistemaConId(string name, long patientId)
    {
        _patientId = patientId;
        _patient = new Patient("12345678A", "Juan", "Perez", new DateOnly(1970, 5, 15), 10L);
        var idProp = typeof(Patient).GetProperty(nameof(Patient.PatientId));
        idProp?.SetValue(_patient, _patientId);
        _patientRepositoryMock.Setup(r => r.FindByIdAsync(_patientId)).ReturnsAsync(_patient);
    }

    [Given("un cuidador registrado con ID (\\d+) que no está vinculado al paciente")]
    public void GivenUnCuidadorRegistradoConIdQueNoEstaVinculadoAlPaciente(long caregiverId)
    {
        _caregiverId = caregiverId;
        var caregiverDummy = new UserInfo(_caregiverId, "caregiver@example.com", "John", "Doe", null);
        _userInfoServiceMock.Setup(s => s.FindByIdAsync(_caregiverId)).ReturnsAsync(caregiverDummy);
    }

    [When("se realiza una solicitud POST a \"/api/patients/(\\d+)/caregivers/qr\" con el ID del cuidador")]
    public async Task WhenSeRealizaUnaSolicitudPostConElIdDelCuidador(long patientId)
    {
        _qrHandler = new LinkCaregiverViaQrCommandHandler(
            _patientRepositoryMock.Object,
            _userInfoServiceMock.Object,
            _unitOfWorkMock.Object
        );
        var command = new LinkCaregiverViaQrCommand(patientId, _caregiverId);
        try
        {
            await _qrHandler.Handle(command, CancellationToken.None);
            _requestResultSuccessful = true;
        }
        catch (Exception ex)
        {
            _requestResultSuccessful = false;
            _errorMessage = ex.Message;
        }
    }

    [Then("el servidor debe responder con un código de estado 200 OK")]
    public void ThenElServidorDebeResponderCon200Ok()
    {
        _requestResultSuccessful.Should().BeTrue(_errorMessage);
    }

    [Then("el cuidador debe quedar vinculado al paciente con el rol por defecto de cuidador")]
    public void ThenElCuidadorDebeQuedarVinculadoAlPacienteConElRolPorDefecto()
    {
        _patient.Should().NotBeNull();
        _patient!.Caregivers.Should().ContainSingle(c => c.UserId == _caregiverId && c.RelationshipTypeId == 1);
        _patientRepositoryMock.Verify(r => r.Update(_patient), Times.Once);
        _unitOfWorkMock.Verify(u => u.CompleteAsync(), Times.Once);
    }
}
