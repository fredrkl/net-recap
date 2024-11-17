# .NET recap

.NET recap. What is new in .net 6 ,7 and 8

## Renovate

This repo uses the [Renovate](https://docs.renovatebot.com/) bot to keep dependencies up to date. I use Renovate over Dependabot because it is more configurable and has more features.

## Lessons - Records

- In order to run a LSP for .NET 7 or newer we need to use the https://github.com/razzmatazz/csharp-language-server instead of Omnisharp-roslyn which only goes up to version 6.
- In order for the LSP to cross projects we need a solution file. This is because the LSP needs to know about the projects in the solution in order to provide intellisense across projects.
- Use `ReferenceEquals()` to compare wheter two reference types are the same object.
- Use `struct` records for small, immutable data structures that you want to store on the stack. For larger data structures, you will want to use reference type records.
- Renovate need access to create or update workflow in order to create a PR updating gh actions.
- Renovate does not use the full url when spesifying individual repositories

## Lessons - WebAPI

- There are mainly two types of ways to create APIs in ASP .NET Core: _minimal APIs_ and _MVC_.
