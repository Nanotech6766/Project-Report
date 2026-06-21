using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class InvitationSteps : CommonSteps
{
    public InvitationSteps(ScenarioContext context) : base(context) { }

    [Given(@"la API de invitaciones está disponible en ""(.*)""")]
    public void GivenInvitationsApi(string basePath)
        => ScenarioContext.Current.Set(basePath, "invitationsBasePath");

    [Given(@"un cuidador principal autenticado con token JWT válido")]
    public async Task GivenOfficialGuardianAuthenticated()
        => await new AuthSteps(ScenarioContext.Current).GivenAuthenticatedCaregiver();

    [Given(@"existe una invitación pendiente con id (.*) para su paciente")]
    public void GivenPendingInvitation(long invitationId)
        => ScenarioContext.Current.Set(invitationId, "invitationId");

    [Then(@"la invitación (.*) debe quedar en estado ""(.*)""")]
    public void ThenInvitationHasStatus(long invitationId, string status)
        => ScenarioContext.Current.Set(status, "invitationStatus");
}
