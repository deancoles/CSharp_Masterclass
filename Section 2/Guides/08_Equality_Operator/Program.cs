// Equality Operator

int num1 = 0;
int num2 = 0;   

// Checks if the values are equal
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

// User enters a number
Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
}
else
{
    Console.WriteLine("Numbers are not equal!");
}

Console.ReadKey();