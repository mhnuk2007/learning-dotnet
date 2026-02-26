# learning-dotnet

Small .NET console apps for practicing core C# concepts.

## Prerequisites

- .NET SDK 10 (`net10.0` targets are used in all projects)

## Projects

| Project | Main Topic | Entry File |
| --- | --- | --- |
| `HelloWorld` | Basic console output | `HelloWorld/Program.cs` |
| `MyConsoleApp` | Console output + `DateTime.Now` | `MyConsoleApp/Program.cs` |
| `Comments` | Single-line, multi-line, and XML comments | `Comments/Program.cs` |
| `Operators` | Arithmetic, comparison, logical, ternary, null-coalescing | `Operators/Program.cs` |
| `Conditionals` | `if`, `if/else`, ternary, switch statement/expression | `Conditionals/Program.cs` |
| `For-Loop` | `for`, `foreach`, character counting | `For-Loop/Program.cs` |
| `While-Loop` | `while` and `do/while` loops with user input | `While-Loop/Program.cs` |
| `ContinueBreak` | `break` and `continue` in loops | `ContinueBreak/Program.cs` |
| `StringParsing` | `Parse` / `TryParse` with `NumberStyles` and `CultureInfo` | `StringParsing/Program.cs` |
| `String-Builder` | `StringBuilder` append, replace, insert, remove, and formatting | `String-Builder/Program.cs` |
| `StringInterpolation` | String interpolation, alignment, and inline expressions | `StringInterpolation/Program.cs` |
| `StringFormatting` | Composite formatting, numeric specifiers, and table-style output | `StringFormatting/Program.cs` |
| `StringOperations` | String APIs, searching, formatting, `StringBuilder` | `StringOperations/Program.cs` |
| `ExceptionHandler` | `try/catch`, specific exceptions, `finally`, `throw` | `ExceptionHandler/Program.cs` |

## Run a Project

From the repository root:

```powershell
dotnet run --project .\StringOperations\StringOperations.csproj
```

Replace `StringOperations` with any project folder above.

To build all projects at once:

```powershell
dotnet build .\MyConsoleApp.slnx
```

## Build Check

Validated on **February 26, 2026** with a full solution build (`MyConsoleApp.slnx`).

- Result: all projects build successfully.
- Build status: `0 Warning(s), 0 Error(s)`.

## Notes

- `MyConsoleApp.slnx` includes all console projects in this repository.
