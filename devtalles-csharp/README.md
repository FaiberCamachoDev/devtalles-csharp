# C# from Scratch — DevTalles

Practice repository for the DevTalles C# course. Each module groups exercises and functional examples around a specific language topic.

## Technologies

- **.NET 9.0**
- **C# 13**
- **System.Text.Json** (JSON serialization, included in the SDK)
- **BetterConsoleTables** (Unicode table rendering in the console)
- **Rider** as the primary IDE

## Project Structure

```
devtalles-csharp/
├── 01-bases/          # Language fundamentals
├── 02-Logic/          # Logic and control flow
├── 03-Classes/        # Object-oriented programming
├── 04-Linq/           # Collections and LINQ
├── 05-Files/          # File handling and JSON
├── 06-TaskMaster/     # Task manager — CRUD, JSON persistence, console tables
├── Program.cs         # Entry point — uncomment the method to run
└── devtalles-csharp.csproj
```

## Modules

### 01 — Bases

Core C# language fundamentals.

| File | Content |
|---|---|
| `variables.cs` | Variable declaration and usage |
| `DataType.cs` | Primitive data types |
| `NumericTypes.cs` | Numeric types and operations |
| `StringType.cs` | String methods and manipulation |
| `arrays.cs` | Single and multi-dimensional arrays |
| `DataStructure.cs` | Basic data structures |
| `ListDictionarys.cs` | Lists and dictionaries |
| `Generics.cs` | Generic types |
| `HandleNullables.cs` | Null handling with `?` and `??` operators |
| `ManageDateTime.cs` | Dates, times and `DateTime` operations |
| `TypeDifference.cs` | Value types vs reference types |
| `inventoryManager.cs` | Practical exercise: inventory manager |
| `HomeWork-1.cs` | Homework 1 |
| `HomeWork-2.cs` | Homework 2 |

### 02 — Logic

Control flow, functions and logical structures.

| File | Content |
|---|---|
| `Conditionals.cs` | `if`, `else`, `switch` |
| `Loops.cs` | `while`, `do while` |
| `For-Foreach.cs` | `for` and `foreach` loops |
| `tuples.cs` | Tuples and destructuring |
| `ConvertStringToDate.cs` | String to date conversion |
| `AnonymousFunctions.cs` | Anonymous functions with `delegate` and lambda expressions `=>` |
| `HomeWork-3.cs` | Homework 3 |
| `HomeWork-4.cs` | Homework 4 |

### 03 — Classes

Object-oriented programming.

| File | Content |
|---|---|
| `TestingClasses.cs` | Class creation and instantiation |
| `Properties.cs` | Properties, getters and setters |
| `Methods.cs` | Methods, parameters and return values |
| `Inheritance.cs` | Inheritance, polymorphism and `override` |
| `AbstractClasses.cs` | Abstract classes and interfaces |
| `HomeWork-6.cs` | Homework 6 |

### 04 — LINQ

Collections and LINQ queries.

| File | Content |
|---|---|
| `Collections.cs` | `List`, `Dictionary`, `HashSet`, `Queue`, `Stack` |
| `Linq.cs` | LINQ operators: `Where`, `Select`, `OrderBy`, `GroupBy`, `First`, `Any`, `All`, `Count` |
| `HomeWork7.cs` | Homework 7 — sales analysis with LINQ |

### 05 — Files

File system handling and JSON serialization.

| File | Content |
|---|---|
| `FileExample.cs` | Reading files with `File.ReadAllText` and `File.ReadLines` |
| `WriterFileExample.cs` | Writing with `StreamWriter`, `File.WriteAllText`, `File.WriteAllLines`, append mode |
| `DirectoryExample.cs` | Creating and deleting directories with `Directory` |
| `PathExample.cs` | Path utilities: file name, extension, directory, combine and full path |
| `ManageJsonFile.cs` | JSON serialization and deserialization with `System.Text.Json`: save, read, add and update records in a file |

### 06 — TaskMaster

Interactive console task manager with JSON persistence and Unicode table display.

| File | Content |
|---|---|
| `Task.cs` | Task model: `Id`, `Description`, `Completed`, `CreatedAt`, `ModifiedAt`, `Deleted` |
| `FileActions.cs` | Generic `FileActions<T>`: serialize/deserialize any list to/from a JSON file |
| `Queries.cs` | CRUD operations: list, add, complete, edit, soft-delete, filter by state or keyword |
| `MainTask.cs` | Interactive menu using a switch expression that returns and invokes `Action` delegates |
| `task.json` | Local JSON database |

---

## How to Run

Uncomment the method you want to test in `Program.cs` and run:

```bash
dotnet run
```

```csharp
// Program.cs — example
static void Main(string[] args)
{
    ManageJsonFile();   // <-- activate the desired method
}
```

## Project Pattern

All modules use `partial class Program`, which allows spreading methods across multiple files without breaking the single entry point in `Program.cs`.
