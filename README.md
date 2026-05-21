# Atata.ExtentReports

[![Atata Templates](https://img.shields.io/badge/get-Atata_Templates-green.svg?color=4BC21F)](https://marketplace.visualstudio.com/items?itemName=YevgeniyShunevych.AtataTemplates)\
[![Slack](https://img.shields.io/badge/join-Slack-green.svg?colorB=4EB898)](https://join.slack.com/t/atata-framework/shared_invite/zt-5j3lyln7-WD1ZtMDzXBhPm0yXLDBzbA)
[![Atata docs](https://img.shields.io/badge/docs-Atata_Framework-orange.svg)](https://atata.io)
[![X](https://img.shields.io/badge/follow-@AtataFramework-blue.svg)](https://x.com/AtataFramework)

**Atata.ExtentReports** is a C#/.NET library that adds ExtentReports reporting to [Atata](https://github.com/atata-framework/atata).

*The package targets .NET 8.0 and .NET Framework 4.6.2.*

## Features

- **Logging**. Writes Atata logs to ExtentReports report.
- **Artifacts**. Attaches various artifacts (screenshots, page snapshots, etc.) to the report.
- **Error handling**. Built-in error handling (screenshots, page snapshots, etc.) on test failures and attaching artifacts to a report.

## Installation

Install the package via .NET CLI:

```bash
dotnet add package Atata.ExtentReports
```

Or using Package Manager:

```powershell
Install-Package Atata.ExtentReports
```

## Usage

In order to integrate ExtentReports with Atata,
call a `UseExtentReports` extension method on the "base" `AtataContextBuilder` instance.

```cs
public sealed class GlobalFixture : AtataGlobalFixture
{
    protected override void ConfigureAtataContextBaseConfiguration(AtataContextBuilder builder)
    {
        builder.UseExtentReports();
    }
}
```

Also you can configure some of the settings:

```cs
builder.UseExtentReports(x => x
    .WithReportTitle("Some title")
    .WithReportFileName("SomeReport.html"));
```

## Examples

Check out example project: [Atata Samples / ExtentReports](https://github.com/atata-framework/atata-samples/tree/main/ExtentReports)

Check out Atata tutorial: [Reporting to ExtentReports](https://atata.io/tutorials/reporting-to-extentreports/)

## Community

- Slack: [https://atata-framework.slack.com](https://join.slack.com/t/atata-framework/shared_invite/zt-5j3lyln7-WD1ZtMDzXBhPm0yXLDBzbA)
- X: https://x.com/AtataFramework
- Stack Overflow: https://stackoverflow.com/questions/tagged/atata

## Feedback

Any feedback, issues and feature requests are welcome.

If you faced an issue please report it to [Atata.ExtentReports Issues](https://github.com/atata-framework/atata-extentreports/issues),
[ask a question on Stack Overflow](https://stackoverflow.com/questions/ask?tags=atata+csharp) using [atata](https://stackoverflow.com/questions/tagged/atata) tag
or use another [Atata Contact](https://atata.io/contact/) way.

## Contact author

Contact me if you need a help in test automation using Atata Framework, or if you are looking for a quality test automation implementation for your project.

- LinkedIn: https://www.linkedin.com/in/yevgeniy-shunevych
- Email: yevgeniy.shunevych@gmail.com
- Consulting: https://atata.io/consulting/

## Contributing

Check out [Contributing Guidelines](CONTRIBUTING.md) for details.

## SemVer

Atata Framework tries to follow [Semantic Versioning 2.0](https://semver.org/) when possible.
Sometimes Selenium.WebDriver dependency package can contain breaking changes in minor version releases,
so those changes can break Atata as well.
But Atata manages its sources according to SemVer.
Thus backward compatibility is mostly followed and updates within the same major version
(e.g. from 2.1 to 2.2) should not require code changes.

## License

Atata is an open source software, licensed under the Apache License 2.0.
See [LICENSE](LICENSE) for details.
