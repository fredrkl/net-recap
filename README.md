# .NET recap

Also showcases automatic releases using semantic-release and automatic dependency updates using Renovate.

.NET recap. What is new in .net 6 ,7 and 8

## Renovate

This repo uses the [Renovate](https://docs.renovatebot.com/) bot to keep dependencies up to date. I use Renovate over Dependabot because it is more configurable and has more features.

## Lessons

### Lessons - Records

- In order to run a LSP for .NET 7 or newer we need to use the https://github.com/razzmatazz/csharp-language-server instead of Omnisharp-roslyn which only goes up to version 6.
- In order for the LSP to cross projects we need a solution file. This is because the LSP needs to know about the projects in the solution in order to provide intellisense across projects.
- Use `ReferenceEquals()` to compare wheter two reference types are the same object.
- Use `struct` records for small, immutable data structures that you want to store on the stack. For larger data structures, you will want to use reference type records.
- Renovate need access to create or update workflow in order to create a PR updating gh actions.
- Renovate does not use the full url when spesifying individual repositories

### Lessons - WebAPI

- There are mainly two types of ways to create APIs in ASP .NET Core: _minimal APIs_ and _MVC_.

### Lessons - feature-explorer

- Host ConfigureServices does have a method to take in a predefined IServiceCollection.
- ConfigurationBuilder is used to build configuration from different sources, e.g. appsettings.json, appsettings.Development.json, environment variables, command line arguments.
- .NET has a built in _feature toggle_ system that can be used to enable or disable features in your application. It is included in the _Microsoft.FeatureManagement_ package

Use Host.CreateApplicationBuilder if:

- You are working with ASP.NET Core or minimal APIs.
- You want a lightweight and opinionated configuration for modern web applications.
- You are using .NET 7 or newer.

Use Host.CreateDefaultBuilder if:
- You need a generic host for non-web applications, such as worker services or console apps.
- You require full flexibility and customization.
- You are targeting .NET 6 or older (or .NET 7+ for non-web apps).

## Build and release

This repo uses gitmoij commits and the semantic-release GitHub Action to automatically create releases. This means that you should use the following commit message format defined in the .releaserc file. See the [gitmoij](https://gitmoji.dev/) on how to use gitmoij.
