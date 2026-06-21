using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using TechTalk.SpecFlow;
using Xunit;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class CommonSteps
{
    private readonly ScenarioContext _context;
    private static readonly HttpClient Client = new() { BaseAddress = new Uri("http://localhost:5237") };

    public CommonSteps(ScenarioContext context) => _context = context;

    [Then(@"la respuesta HTTP debe ser (.*)")]
    public void ThenHttpStatusShouldBe(int statusCode)
    {
        var response = _context.Get<HttpResponseMessage>("httpResponse");
        Assert.Equal((HttpStatusCode)statusCode, response.StatusCode);
    }

    [Then(@"la respuesta debe incluir un token JWT válido")]
    public async Task ThenResponseContainsJwt()
    {
        var response = _context.Get<HttpResponseMessage>("httpResponse");
        var payload = await response.Content.ReadFromJsonAsync<LoginResponse>();
        Assert.False(string.IsNullOrWhiteSpace(payload?.Token));
    }

    protected async Task SendAsync(HttpMethod method, string path, object? body = null, bool authenticated = false)
    {
        using var request = new HttpRequestMessage(method, path);
        if (body is not null)
            request.Content = JsonContent.Create(body);

        if (authenticated && _context.ContainsKey("authToken"))
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _context.Get<string>("authToken"));

        var response = await Client.SendAsync(request);
        _context.Set(response, "httpResponse");
    }

    private sealed record LoginResponse(string Token, string Email);
}
