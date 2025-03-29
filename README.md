# WorkshopAI Project

## Description

This project has intentional errors because the idea is to fix them with GitHub Copilot, and then add unit tests using the xUnit library, always using GitHub Copilot as an assistant.

## Instructions

### Project Preparation

1. **Error Correction**:
   - Remember that to run the project, you must first fix all the bugs so that it can compile without problems.
   - Once it compiles perfectly, you can add the unit tests.

### Visual Studio Code Setup

2. **Recommended Extensions**:
   - If you are using Visual Studio Code, you should add an extension for C# for better code management.

### Commands to Run Unit Tests

3. **Compile the Project**:

   ```bash
   dotnet build WorkshopAI.sln
   ```

4. **Run All Unit Tests**:

   ```bash
   dotnet test
   ```

5. **Run a Specific Unit Test**:

   ```bash
   dotnet test --filter "FullyQualifiedName=Namespace.Class.TestName"
   ```

   **Example:**

   ```bash
   dotnet test --filter "FullyQualifiedName=ArithmeticDemo.Tests.BasicMathOperations.AdditionTests.AdditionOperation_TwoPositiveNumbers_ReturnsCorrectSum"
   ```

