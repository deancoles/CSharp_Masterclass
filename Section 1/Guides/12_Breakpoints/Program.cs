// Breakpoints allows developers to pause the execution of their program to inspect variables and program flow.

int num1 = 14;
Console.WriteLine("Please enter a whole number");

// breakpoint created, code will pause here
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Age is {num1 + num2}");

Console.ReadKey();
