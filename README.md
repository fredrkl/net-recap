# .NET recap

.NET recap. What is new in .net 6 ,7 and 8

## Lessons

- In order to run a LSP for .NET 7 or newer we need to use the https://github.com/razzmatazz/csharp-language-server instead of Omnisharp-roslyn which only goes up to version 6.
- In order for the LSP to cross projects we need a solution file. This is because the LSP needs to know about the projects in the solution in order to provide intellisense across projects.
- Use `ReferenceEquals()` to compare wheter two reference types are the same object.
- Use `struct` records for small, immutable data structures that you want to store on the stack. For larger data structures, you will want to use reference type records.
- Renovate need access to create or update workflow in order to create a PR updating gh actions.
- Renovate does not use the full url when spesifying individual repositories
