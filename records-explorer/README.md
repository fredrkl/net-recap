# Records Explorer

Records explorer is the project to explore the new feature of C# 9.0, Records.

Records are reference types that provide synthesized methods to implement value equality. They are immutable and can be deconstructed. It is important to note that records are reference types, not value types.

In C#, records are a reference type by default, which means they are stored on the heap. However, C# 9.0 introduced the concept of `record` types, which can be either reference types or value types. This project uses .net 8 which used the C# version 12.

1. **Reference Type Records**: By default, when you define a record, it is a reference type and is stored on the heap. For example:

    ```csharp
    public record Person(string FirstName, string LastName);
    ```

    Instances of `Person` will be stored on the heap.

2. **Value Type Records**: If you want a record to be a value type, you can use the `record struct` keyword. Value type records are stored on the stack (or inline within other objects if they are fields of those objects). For example:

    ```csharp
    public record struct Point(int X, int Y);
    ```

    Instances of `Point` will be stored on the stack.

In summary:
- **Reference type records** (default) are stored on the heap.


## Links
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
