using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class PatientSteps : CommonSteps
{
    public PatientSteps(ScenarioContext context) : base(context) { }

    [Given(@"existe un paciente con id (.*) vinculado al cuidador autenticado")]
    public void GivenPatientLinkedToCaregiver(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientId");

    [Given(@"existe un paciente con id (.*) con bloodType ""(.*)"" y alergia ""(.*)""")]
    public void GivenPatientWithMedicalData(long patientId, string bloodType, string allergy)
    {
        ScenarioContext.Current.Set(patientId, "patientId");
        ScenarioContext.Current.Set(bloodType, "bloodType");
        ScenarioContext.Current.Set(allergy, "allergy");
    }

    [Given(@"el cuidador autenticado tiene pacientes asignados")]
    public void GivenCaregiverHasPatients() { }

    [Given(@"el paciente (.*) tiene un contacto de emergencia con id (.*)")]
    public void GivenPatientHasEmergencyContact(long patientId, long contactId)
    {
        ScenarioContext.Current.Set(patientId, "patientId");
        ScenarioContext.Current.Set(contactId, "contactId");
    }

    [Then(@"el paciente creado debe tener DNI ""(.*)""")]
    public async Task ThenCreatedPatientHasDni(string dni)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(dni, json);
    }

    [Then(@"el paciente (.*) debe tener bloodType ""(.*)""")]
    public void ThenPatientHasBloodType(long patientId, string bloodType)
        => ScenarioContext.Current.Set(bloodType, "expectedBloodType");

    [Then(@"el paciente (.*) debe incluir la alergia ""(.*)""")]
    public void ThenPatientHasAllergy(long patientId, string allergy)
        => ScenarioContext.Current.Set(allergy, "expectedAllergy");

    [Then(@"el paciente (.*) debe tener un contacto con teléfono ""(.*)""")]
    public void ThenPatientHasContactPhone(long patientId, string phone)
        => ScenarioContext.Current.Set(phone, "expectedPhone");

    [Then(@"el paciente (.*) no debe incluir el contacto (.*)")]
    public void ThenPatientDoesNotHaveContact(long patientId, long contactId) { }

    [Then(@"el cuerpo debe incluir firstName y lastName del paciente")]
    public async Task ThenBodyIncludesPatientNames()
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains("firstName", json, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("lastName", json, StringComparison.OrdinalIgnoreCase);
    }

    [Then(@"el cuerpo debe incluir bloodType ""(.*)""")]
    public async Task ThenBodyIncludesBloodType(string bloodType)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(bloodType, json);
    }

    [Then(@"el cuerpo debe incluir medicalConditions con ""(.*)""")]
    public async Task ThenBodyIncludesAllergy(string allergy)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(allergy, json);
    }
}
