# .NET recap

.NET recap. What is new in .net 6 ,7 and 8

## Lessons

- In order to run a LSP for .NET 7 or newer we need to use the https://github.com/razzmatazz/csharp-language-server instead of Omnisharp-roslyn which only goes up to version 6.
- In order for the LSP to cross projects we need a solution file. This is because the LSP needs to know about the projects in the solution in order to provide intellisense across projects.
