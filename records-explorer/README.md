# Records Explorer

`Records explorer` explores the new feature of C# 9.0, Records.

Records are reference types that provide synthesized methods to implement value equality. They are immutable per default and can be deconstructed. It is important to note that records are reference types, not value types.

In C#, records are a reference type by default, which means they are stored on the heap. This project uses .net 8 which used the C# version 12.

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

As I see it, you will only want to use value type records when you have a small, immutable data structure that you want to store on the stack. For larger data structures, you will want to use reference type records. Record structs do not support inheritence.

## When to use either

- Use reference type records when you have a large data structure that you want to store on the heap.
- Use value type records when you have a small, immutable data structure that you want to store on the stack.Good for performance critical applications.

## Record vs Record Class

Specifying `Record Class` instead of only `Record` is not necessary. The `Record` keyword is enough to define a record type. The `Record Class` is to used to make it more explicit.

- `record class` is an alias for `record`.
- `record struct` is used to define a value type record.

## Constructor

When you define primary constructors in a record, the compiler will generate a constructor for you. You can also define additional constructors in a record. The additional constructors must call the primary constructor.

In summary:
- **Reference type records** (default) are stored on the heap.
- **Value type records** are stored on the stack.

## Links
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
