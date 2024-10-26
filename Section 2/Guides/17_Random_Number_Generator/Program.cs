// Random Number Generator

// creating an instance of the Random Class
Random random = new Random();

// will give a random number between 1 and 10
int randomNumber = random.Next(1, 11);

// user guesses the number
Console.WriteLine("Guess the number");
string inputString = Console.ReadLine();
int num1 = 0;

// Try parse attempts to convert a string and returns a boolean showing if conversion succeeded, will not cause exception if it fails
bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guessed right");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again");
    }
}
else
{
    Console.WriteLine("Haha you troll, you should have entered a number");
}
Console.ReadKey();