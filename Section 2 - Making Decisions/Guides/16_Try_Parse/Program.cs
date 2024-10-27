// Try parse

Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1;

// Try parse attempts to convert a string and returns a boolean showing if conversion succeeded, will not cause exception if it fails
bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    Console.WriteLine("Well done, you entered a number");
}
else
{
    Console.WriteLine("Haha you troll, you should have entered a number");
}

num1++;
Console.WriteLine("User entered number + 1 " + num1);

Console.ReadKey();