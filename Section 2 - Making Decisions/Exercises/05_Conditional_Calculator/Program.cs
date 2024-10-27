// Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:
// Prompt the user to enter two numbers.
// Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
// Use conditional statements to perform the selected operation.
// Print the result of the operation to the console.
// Handle division by zero with a specific message.


// User inputs numbers and the operation
Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());     // Converts user input into a double
Console.WriteLine("Enter the second number:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose an operation: +, -, *, /");   
string userOperation = Console.ReadLine();

double userResult;                                      // Declare a variable that stores the result    

// Addition
if (userOperation == "+")
{
    userResult = num1 + num2;
    Console.WriteLine($"Result: {userResult}");
}
// Subtraction
else if (userOperation == "-")
{
    userResult = num1 - num2;
    Console.WriteLine($"Result: {userResult}");
}
// Multiplication
else if (userOperation == "*")
{
    userResult = num1 * num2;
    Console.WriteLine($"Result: {userResult}");
}
// Division
else if (userOperation == "/")
{
    if (num2 != 0)                                      // Check if second number is not zero to avoid division by zero.
    {
        userResult = num1 / num2;
        Console.WriteLine($"Result: {userResult}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
// Error Message
else
{
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}


Console.ReadKey();