namespace Atata.ExtentReports.IntegrationTests;

public class GlobalFixture : AtataGlobalFixture
{
    protected override void ConfigureAtataContextGlobalProperties(AtataContextGlobalProperties globalProperties) =>
        globalProperties.UseRootNamespaceOf<GlobalFixture>();

    protected override void ConfigureAtataContextBaseConfiguration(AtataContextBuilder builder)
    {
        builder.Sessions.AddWebDriver(x => x
            .UseStartScopes(AtataContextScopes.Test)
            .UseBaseUrl("https://demo.atata.io/")
            .UseChrome(x => x
                .WithArguments("headless=new", "window-size=1024,768", "disable-search-engine-choice-screen")));

        builder.LogConsumers.AddNLogFile();
        builder.UseExtentReports();
    }

    protected override void ConfigureGlobalAtataContext(AtataContextBuilder builder) =>
        builder.EventSubscriptions.Add(SetUpWebDriversForUseEventHandler.Instance);
}
