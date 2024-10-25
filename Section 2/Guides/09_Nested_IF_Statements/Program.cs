// Nested IF Statements and Global variables

// Global variables declared
int num1 = 0;
int num2 = 0;
int age = 0;
string address = "";

// Checks if the values are equal
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

// User enters a whole number
Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))              // Converts the string to an int
{
    Console.WriteLine("Numbers are equal!");

    // User enters their age
    Console.WriteLine("Please enter your age");
    age = int.Parse(Console.ReadLine());                // Global variable can be accessed as it was created outside of If statement
    
    // Nested IF statement
    if (age >= 18)
    {
        Console.WriteLine("Please enter your address, so we can send your prize");
        address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't claim the prize due to your age!");
    }
}
else
{
    Console.WriteLine("Numbers are not equal!");
}

Console.ReadKey();
