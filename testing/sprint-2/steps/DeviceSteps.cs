using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class DeviceSteps : CommonSteps
{
    public DeviceSteps(ScenarioContext context) : base(context) { }

    [Given(@"existe un dispositivo IoT con id (.*) sin paciente asignado")]
    public void GivenUnassignedDevice(long deviceId)
        => ScenarioContext.Current.Set(deviceId, "deviceId");

    [Given(@"el paciente (.*) tiene el dispositivo (.*) vinculado")]
    public void GivenPatientHasDevice(long patientId, long deviceId)
    {
        ScenarioContext.Current.Set(patientId, "patientId");
        ScenarioContext.Current.Set(deviceId, "deviceId");
    }

    [Then(@"el dispositivo (.*) debe estar asignado al paciente (.*)")]
    public void ThenDeviceAssignedToPatient(long deviceId, long patientId) { }

    [Then(@"la respuesta debe incluir deviceId (.*)")]
    public async Task ThenResponseIncludesDeviceId(long deviceId)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(deviceId.ToString(), json);
    }
}
