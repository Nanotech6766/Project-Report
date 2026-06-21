using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class AuthSteps : CommonSteps
{
    public AuthSteps(ScenarioContext context) : base(context) { }

    [Given(@"la API de IAM está disponible en ""(.*)""")]
    public void GivenIamApiIsAvailable(string basePath)
    {
        ScenarioContext.Current.Set(basePath, "iamBasePath");
    }

    [Given(@"existe un cuidador con email ""(.*)"" y contraseña ""(.*)""")]
    public async Task GivenCaregiverExists(string email, string password)
    {
        await SendAsync(HttpMethod.Post, "/api/iam/auth/register", new
        {
            email,
            password,
            firstName = "Test",
            lastName = "User"
        });
    }

    [Given(@"existe un cuidador con email ""(.*)""")]
    public Task GivenCaregiverWithEmailExists(string email)
        => GivenCaregiverExists(email, "Secure123!");

    [Given(@"un cuidador autenticado con token JWT válido")]
    public async Task GivenAuthenticatedCaregiver()
    {
        await GivenCaregiverExists("auth.user@foll.test", "Secure123!");
        await SendAsync(HttpMethod.Post, "/api/iam/auth/login", new
        {
            email = "auth.user@foll.test",
            password = "Secure123!"
        });

        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var payload = await response.Content.ReadFromJsonAsync<AuthPayload>();
        ScenarioContext.Current.Set(payload!.Token, "authToken");
    }

    [When(@"envío una petición POST a ""(.*)"" con:")]
    public async Task WhenPostWithTable(string path, Table table)
    {
        var row = table.Rows[0];
        var body = row.Header.ToDictionary(h => h, h => row[h]);
        await SendAsync(HttpMethod.Post, path, body, path.Contains("/patients") || path.Contains("/notifications") || path.Contains("/devices"));
    }

    [Then(@"el cuerpo de la respuesta debe contener el email ""(.*)""")]
    public async Task ThenBodyContainsEmail(string email)
    {
        var response = ScenarioContext.Current.Get<HttpResponseMessage>("httpResponse");
        var json = await response.Content.ReadAsStringAsync();
        Assert.Contains(email, json, StringComparison.OrdinalIgnoreCase);
    }

    private sealed record AuthPayload(string Token, string Email);
}
