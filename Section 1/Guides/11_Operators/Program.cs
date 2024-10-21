// Operators and Order of Evaluation

// values
int num1 = 5;
int num2 = 13;

Console.WriteLine("Addition num1 + num2 = " + (num1 + num2));

// order of evaluation without brackets
// "Subtraction num1 - num2 = 5" - 13
// it would concatenate num 1 to the string
Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));

Console.WriteLine("Multiplication num1 * num2 = " + (num1 * num2));
Console.WriteLine("Division num1 / num2 = " + (num1 / num2));

// Order of operations
// without brackets
// 5 + 3 - 8 * 2
// 5 + 3 - 16 = -8
// with brackets
// 5 + (3-8) * 2
// 5 + (-5) * 2
// 5 + -10 = -5

// interpolation method
Console.WriteLine();
Console.WriteLine("The same sums done with interpolation");

Console.WriteLine($"Addition num1 + num2 = {num1 + num2}");
Console.WriteLine($"Substraction num1 - num2 = {num1 - num2}");
Console.WriteLine($"Multiplication num1 * num2 = {num1 * num2}");
Console.WriteLine($"Division num1 / num2 = {num1 / num2}");