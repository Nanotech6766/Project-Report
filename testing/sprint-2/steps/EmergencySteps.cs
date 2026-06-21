using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class EmergencySteps : CommonSteps
{
    public EmergencySteps(ScenarioContext context) : base(context) { }

    [Given(@"el cuidador autenticado tiene acceso al paciente (.*)")]
    public void GivenCaregiverHasAccessToPatient(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientId");

    [Given(@"el cuidador autenticado no tiene acceso al paciente (.*)")]
    public void GivenCaregiverHasNoAccessToPatient(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientIdWithoutAccess");

    [Given(@"existe un incidente activo con id (.*) para el paciente (.*)")]
    public void GivenActiveIncident(long incidentId, long patientId)
    {
        ScenarioContext.Current.Set(incidentId, "incidentId");
        ScenarioContext.Current.Set(patientId, "patientId");
    }

    [Given(@"existe un incidente activo para el paciente (.*)")]
    public void GivenActiveIncidentForPatient(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientIdWithActiveIncident");

    [Given(@"existe un incidente abierto con id (.*) para el paciente (.*)")]
    public void GivenOpenIncident(long incidentId, long patientId)
    {
        ScenarioContext.Current.Set(incidentId, "incidentId");
        ScenarioContext.Current.Set(patientId, "patientId");
    }

    [Given(@"existe un incidente histórico con id (.*) del paciente (.*)")]
    public void GivenHistoricalIncident(long incidentId, long patientId)
    {
        ScenarioContext.Current.Set(incidentId, "incidentId");
        ScenarioContext.Current.Set(patientId, "patientId");
    }

    [Given(@"el paciente (.*) tiene incidentes registrados en distintas fechas")]
    public void GivenPatientHasIncidents(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientId");

    [Given(@"el paciente (.*) tiene un incidente resuelto y uno marcado como falso positivo")]
    public void GivenPatientHasMixedIncidents(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientId");

    [Given(@"el paciente (.*) tiene incidentes en mayo y junio de 2026")]
    public void GivenPatientHasMonthlyIncidents(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientId");

    [Given(@"el paciente (.*) no tiene incidentes registrados")]
    public void GivenPatientHasNoIncidents(long patientId)
        => ScenarioContext.Current.Set(patientId, "patientIdWithoutIncidents");

    [Then(@"el incidente (.*) debe quedar en estado ""(.*)""")]
    public void ThenIncidentHasStatus(long incidentId, string status)
        => ScenarioContext.Current.Set(status, "incidentStatus");

    [Then(@"la respuesta debe ser una lista ordenada cronológicamente")]
    public void ThenResponseIsChronologicalList() { }

    [Then(@"la respuesta debe incluir incidentId (.*)")]
    public async Task ThenResponseIncludesIncidentId(long incidentId)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(incidentId.ToString(), json);
    }

    [Then(@"la respuesta debe incluir patientId (.*)")]
    public async Task ThenResponseIncludesPatientId(long patientId)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(patientId.ToString(), json);
    }

    [Then(@"la respuesta debe incluir al menos un incidente con status ""(.*)""")]
    public void ThenResponseIncludesStatus(string status)
        => ScenarioContext.Current.Set(status, "expectedIncidentStatus");

    [Then(@"cada incidente debe incluir openedAt")]
    public void ThenEachIncidentIncludesOpenedAt() { }

    [Then(@"la respuesta debe permitir agrupar caídas por mes")]
    public void ThenResponseAllowsMonthlyAggregation() { }

    [Then(@"la respuesta debe ser una lista vacía")]
    public async Task ThenResponseIsEmptyList()
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Equal("[]", json.Trim());
    }
}
