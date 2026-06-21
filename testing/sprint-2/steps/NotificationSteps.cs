using TechTalk.SpecFlow;

namespace Foll.Testing.Sprint2.Steps;

[Binding]
public class NotificationSteps : CommonSteps
{
    public NotificationSteps(ScenarioContext context) : base(context) { }

    [Given(@"existe una notificación de caída con id (.*) dirigida al cuidador autenticado")]
    public void GivenFallNotificationForCaregiver(long notificationId)
        => ScenarioContext.Current.Set(notificationId, "notificationId");

    [Given(@"existe una notificación con id (.*) dirigida a otro cuidador")]
    public void GivenNotificationForOtherCaregiver(long notificationId)
        => ScenarioContext.Current.Set(notificationId, "notificationId");

    [Then(@"la notificación (.*) debe quedar en estado ""(.*)""")]
    public void ThenNotificationHasStatus(long notificationId, string status)
        => ScenarioContext.Current.Set(status, "notificationStatus");
}
