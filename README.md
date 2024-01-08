

# Guided Assignment: Parsing Data and Error Handling with Try-Catch Blocks in C#

## Introduction
In C#, parsing is the process of converting a string representation of data into a different data type, such as an integer, floating-point number, or custom class object. Parsing is commonly used when working with user input, reading data from files, or communicating with external systems. However, parsing can lead to exceptions when the input data format doesn't match the expected format. To handle these exceptions gracefully, C# provides the try-catch block, which allows you to catch and handle errors that might occur during parsing.

In this tutorial, you will learn how to effectively handle errors using try-catch blocks when parsing data from strings.

---

## Requirements

#### Project Setup (10 Points)
- Create a new console application named `GA_ParsingAndTryCatch_YourName`.
- Ensure the project is properly set up with `Program.cs`.

#### Error Handling with try-catch (30 Points)
- Explain the purpose of `try-catch` blocks in handling exceptions.
- Provide examples of using `try-catch` blocks to catch and handle parsing errors.
- Discuss best practices for error message handling and logging.

#### Parsing Data from Strings (25 Points)
- Explain the importance of data parsing in C#.
- Provide examples of parsing different data types, such as integers and doubles.
- Include error handling using `try-catch` blocks for each parsing example.

#### Parsing Multiple Values (20 Points)
- Demonstrate how to read and parse multiple values, such as integers and doubles, one after another.
- Include error handling using `try-catch` blocks for parsing multiple values.

#### Code Testing and Validation (10 Points)
- Test all parsing and error handling examples in the `Main` method.
- Validate the results with detailed explanations.

#### Code Readability and Documentation (5 Points)
- Write well-organized and readable code.
- Include comprehensive comments explaining the logic and purpose of the code.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Submit the correct GitHub repository link in Canvas.

#### Total (100 Points)
- Each section is mandatory, and points are awarded based on fulfilling each detailed requirement accurately.

---

## Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring Data Parsing and Try-Catch Blocks in C#");
        // Additional implementation will follow
    }
}
```

---

## Step-by-Step Implementation

### **Step 1: Error Handling with try-catch**

Explain the purpose of `try-catch` blocks in handling exceptions.

```csharp
try
{
    // Code that may throw exceptions
}
catch (Exception ex)
{
    // Handle the exception
    Console.WriteLine($"An error occurred: {ex.Message}");
}
```

In C#, the `try-catch` block is used to handle exceptions. It allows you to enclose code that may potentially throw an exception within a `try` block. If an exception occurs within the `try` block, the corresponding `catch` block(s) can catch and handle the exception. This mechanism helps prevent the program from crashing due to unexpected errors and enables you to provide meaningful error messages or take specific actions when exceptions occur.

In the example above, we have a generic `try-catch` block. If any exception is thrown inside the `try` block, it will be caught, and the error message will be displayed using `ex.Message`.

### **Step 2: Parsing Data from Strings**

Explain the importance of data parsing in C#.

```csharp
string numericString = "42";
int parsedInt;

try
{
    parsedInt = int.Parse(numericString);
    Console.WriteLine($"Parsed integer: {parsedInt}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format for parsing integer.");
}
catch (OverflowException)
{
    Console.WriteLine("Value is too large or too small for an integer.");
}
```

In C#, data parsing is crucial when you need to convert data from one format (usually a string) to another format (such as an integer, floating-point number, or date). It is commonly used for scenarios like processing user input, reading data from external sources, or handling data received from web services. However, parsing can lead to exceptions when the input data doesn't match the expected format.

In the example above, we attempt to parse a numeric string into an integer. We use a `try-catch` block to handle potential exceptions. The `FormatException` is caught when the input string cannot be converted to an integer due to incorrect format, and the `OverflowException` is caught when the value is too large or too small to fit into an integer.

### **Step 3: Parsing Integers**

Parsing integers is a common operation when working with user input or reading data from various sources. It's important to understand how to parse integers and handle potential parsing errors using `try-catch` blocks.

#### Parsing Integers

```csharp
string numericString = "42";
int parsedInt;

try
{
    parsedInt = int.Parse(numericString);
    Console.WriteLine($"Parsed integer: {parsedInt}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format for parsing integer.");
}
catch (OverflowException)
{
    Console.WriteLine("Value is too large or too small for an integer.");
}
```

In this code snippet:

- We have a numeric string `"42"`.
- We attempt to parse it into an integer using `int.Parse()`.
- A `try-catch` block is used to handle potential exceptions.
- `FormatException` is caught when the input string cannot be converted to an integer due to an incorrect format.
- `OverflowException` is caught when the value is too large or too small to fit into an integer.

This example demonstrates how to parse integers and handle common parsing exceptions.

### **Step 4: Parsing Doubles**

Parsing floating-point numbers, such as doubles, is essential when dealing with numeric data. Let's explore how to parse doubles and handle potential parsing errors.

#### Parsing Doubles

```csharp
string doubleString = "3.14";
double parsedDouble;

try
{
    parsedDouble = double.Parse(doubleString);
    Console.WriteLine($"Parsed double: {parsedDouble}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format for parsing

 double.");
}
```

In this code snippet:

- We have a string `"3.14"`, representing a floating-point number.
- We attempt to parse it into a double using `double.Parse()`.
- A `try-catch` block is used to handle potential exceptions.
- `FormatException` is caught when the input string cannot be converted to a double due to an incorrect format.

This example demonstrates how to parse double values and handle parsing exceptions.

### **Step 5: Parsing Multiple Values**

Often, you'll need to parse multiple values, one after another. Let's look at an example of reading multiple inputs and parsing them.

#### Parsing Multiple Values

```csharp
Console.Write("Enter an integer: ");
string input1 = Console.ReadLine();

Console.Write("Enter a double: ");
string input2 = Console.ReadLine();

int parsedInt;
double parsedDouble;

try
{
    parsedInt = int.Parse(input1);
    parsedDouble = double.Parse(input2);

    Console.WriteLine($"Parsed integer: {parsedInt}");
    Console.WriteLine($"Parsed double: {parsedDouble}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input format.");
}
```

In this code snippet:

- We prompt the user to enter an integer and a double.
- We read these values as strings using `Console.ReadLine()`.
- We attempt to parse the input strings into integers and doubles using `int.Parse()` and `double.Parse()`.
- A `try-catch` block is used to handle potential exceptions.
- If a `FormatException` occurs, we catch it and display an "Invalid input format" error message.

This example demonstrates how to read and parse multiple values one after another, handling parsing exceptions along the way.

### **Step 6: Code Testing and Validation**

Test all parsing and error handling examples in the `Main` method.

```csharp
Console.WriteLine($"Parsed integer: {parsedInt}");
Console.WriteLine($"Parsed double: {parsedDouble}");
```

### **Step 7: Code Readability and Documentation**

Write well-organized and readable code. Include comprehensive comments explaining the logic and purpose of the code.

### **Step 8: Submission**

- Review and organize your code.
- Upload to GitHub and submit the link in Canvas.

---

## Revised Rubric

| Criteria                        | Description                                              | Points |
|---------------------------------|----------------------------------------------------------|--------|
| **Project Setup**               | Correct project creation and setup.                      | 10     |
| **Error Handling with try-catch** | Explanation and examples of error handling using try-catch blocks for parsing data. | 30     |
| **Parsing Data from Strings**   | Explanation and examples of parsing different data types, such as integers and doubles, with try-catch blocks. | 25     |
| **Parsing Multiple Values**      | Demonstrate how to read and parse multiple values, such as integers and doubles, one after another, with error handling. | 20     |
| **Code Testing and Validation**  | Effective testing, validation, and explanation of results. | 10     |
| **Code Readability and Documentation** | Well-organized and documented code.                      | 5      |
| **Submission**                  | Proper GitHub upload and submission.                      | 5      |

**Total: 100 Points**
