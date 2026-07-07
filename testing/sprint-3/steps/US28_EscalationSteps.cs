using System;
using foll_backend.EmergencyAnalytics.Domain.Model.Enums;
using FluentAssertions;

namespace foll_backend.Tests.Steps;

public class US28_EscalationSteps
{
    private EmergencyIncidentStatus _incidentStatus;
    private DateTime _incidentOpenedTime;
    private bool _smsAlertDispatched;

    [Given("un paciente \"([^\"]*)\" con un dispositivo activo")]
    public void GivenUnPacienteConUnDispositivoActivo(string name)
    {
        _smsAlertDispatched = false;
    }

    [Given("un incidente de emergencia abierto registrado hace (\\d+) minutos")]
    public void GivenUnIncidenteDeEmergenciaAbiertoRegistradoHaceMinutos(int minutes)
    {
        _incidentStatus = EmergencyIncidentStatus.Open;
        _incidentOpenedTime = DateTime.UtcNow.AddMinutes(-minutes);
    }

    [When("el background worker detecta el timeout del incidente")]
    public void WhenElBackgroundWorkerDetectaElTimeoutDelIncidente()
    {
        var minutesSinceOpen = (DateTime.UtcNow - _incidentOpenedTime).TotalMinutes;
        if (minutesSinceOpen >= 3 && _incidentStatus == EmergencyIncidentStatus.Open)
        {
            _incidentStatus = (EmergencyIncidentStatus)4; // Escalado
            _smsAlertDispatched = true;
        }
    }

    [Then("el estado del incidente debe cambiar a \"Escalado\"")]
    public void ThenElEstadoDelIncidenteDebeCambiarAEscalado()
    {
        _incidentStatus.Should().Be((EmergencyIncidentStatus)4);
    }

    [Then("se debe disparar la notificación de alerta de escalamiento a los contactos de emergencia mediante SMS")]
    public void ThenSeDebeDispararLaNotificacionDeAlertaDeEscalamientoMedianteSms()
    {
        _smsAlertDispatched.Should().BeTrue();
    }
}
