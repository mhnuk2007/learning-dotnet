# learning-dotnet

Exercises and code challenges completed while taking the LinkedIn Learning course **Learning C#**.

## Course Completion

- Course: [Learning C#](https://www.linkedin.com/learning/learning-c-sharp-8581491/an-introduction-to-learning-c-sharp?contextUrn=urn%3Ali%3AlyndaLearningPath%3A5ebaefdc498e440b07b53ea1)
- Status: Completed on **February 27, 2026**
- Repository status: All assigned tasks and challenge exercises completed

## Prerequisites

- .NET SDK 10 (`net10.0` targets are used in all projects)

## Projects

| Category | Project | Main Topic | Entry File |
| --- | --- | --- | --- |
| Basics | `HelloWorld` | Basic console output | `HelloWorld/Program.cs` |
| Basics | `MyConsoleApp` | Console output + `DateTime.Now` | `MyConsoleApp/Program.cs` |
| Basics | `Comments` | Single-line, multi-line, and XML comments | `Comments/Program.cs` |
| Basics | `Operators` | Arithmetic, comparison, logical, ternary, null-coalescing | `Operators/Program.cs` |
| Control Flow | `Conditionals` | `if`, `if/else`, ternary, switch statement/expression | `Conditionals/Program.cs` |
| Control Flow | `For-Loop` | `for`, `foreach`, character counting | `For-Loop/Program.cs` |
| Control Flow | `While-Loop` | `while` and `do/while` loops with user input | `While-Loop/Program.cs` |
| Control Flow | `ContinueBreak` | `break` and `continue` in loops | `ContinueBreak/Program.cs` |
| Control Flow | `ExceptionHandler` | `try/catch`, specific exceptions, `finally`, `throw` | `ExceptionHandler/Program.cs` |
| Functions | `FunctionBasics` | Basic method definition and invocation | `FunctionBasics/Program.cs` |
| Functions | `FunctionParams` | Default and named method parameters | `FunctionParams/Program.cs` |
| Functions | `FunctionRefOutParams` | `ref` / `out` parameters and multi-result pattern | `FunctionRefOutParams/Program.cs` |
| Functions | `FunctionMultiValues` | Tuples and tuple-based multi-value returns | `FunctionMultiValues/Program.cs` |
| Functions | `FunctionCodeChallenge` | Palindrome detection with character filtering and two-pointer compare | `FunctionCodeChallenge/Program.cs` |
| Strings | `StringOperations` | String APIs, searching, formatting, `StringBuilder` | `StringOperations/Program.cs` |
| Strings | `StringParsing` | `Parse` / `TryParse` with `NumberStyles` and `CultureInfo` | `StringParsing/Program.cs` |
| Strings | `String-Builder` | `StringBuilder` append, replace, insert, remove, and formatting | `String-Builder/Program.cs` |
| Strings | `StringInterpolation` | String interpolation, alignment, and inline expressions | `StringInterpolation/Program.cs` |
| Strings | `StringFormatting` | Composite formatting, numeric specifiers, and table-style output | `StringFormatting/Program.cs` |
| Strings | `StringCodeChallenge` | Type-name checks using `GetType().Name` | `StringCodeChallenge/Program.cs` |
| Classes/OOP | `ClassesDefining` | Class definition basics and field-access visibility demo | `ClassesDefining/Program.cs` |
| Classes/OOP | `ClassesProperties` | Backing fields, auto-properties, expression-bodied properties | `ClassesProperties/Program.cs` |
| Classes/OOP | `ClassesModifiers` | `public`, `private`, `protected` member access patterns | `ClassesModifiers/Program.cs` |
| Classes/OOP | `ClassesStringRep` | Overriding and overloading `ToString()` | `ClassesStringRep/Program.cs` |
| Classes/OOP | `ClassesInheritance` | Base classes, derived classes, virtual/override methods | `ClassesInheritance/Program.cs` |
| Classes/OOP | `ClassesCodeChallenge` | Bank account inheritance with savings/checking behavior | `ClassesCodeChallenge/Program.cs` |

## Run and Build

Run a specific project from repository root:

```powershell
dotnet run --project .\StringOperations\StringOperations.csproj
```

Build the tracked solution projects:

```powershell
dotnet build .\MyConsoleApp.slnx
```

## Build Check

Validated on **February 27, 2026**.

- Solution build (`MyConsoleApp.slnx`, 25 projects): `0 Warning(s), 0 Error(s)`.
- Full project scan (26 `.csproj` files): `ClassesDefining` intentionally raises `CS0122` in `Program.cs` for the access-modifier lesson.

## Notes

- `MyConsoleApp.slnx` includes all runnable projects used for consolidated builds.
- `ClassesDefining` keeps an intentional compile-time example (`Book._name` access) to demonstrate protection-level rules.
