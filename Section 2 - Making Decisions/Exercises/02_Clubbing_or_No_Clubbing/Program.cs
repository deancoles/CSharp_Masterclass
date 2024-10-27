// An application designed to check if a person is old enough to go out, go with an adult, or stay home
                                                                   
Console.WriteLine("How old are you?");                              
int age = int.Parse(Console.ReadLine());                            // Age input
bool isWithAdult = false;                                           // Adult bool

if (age >= 18)                                                      // If they are 18 years old
{
    Console.WriteLine("Go party in the club!");
}
else if (age >= 13)                                                 // If they are between 13 and 17
{
    Console.WriteLine("Are you with an adult? Answer with Y or N"); // Verifies they have an adult with them
    string isWithAdultString = Console.ReadLine().ToUpper();        // Converts input to uppercase

    if (isWithAdultString == "Y")                                   // Nested IF statement
    {
        Console.WriteLine("You go to the party with an adult");
    }
    else
    {
        Console.WriteLine("You must be with an adult to party");
    }
}
else                                                                // If they are under 13
{
    Console.WriteLine("No fun for you!");
}

Console.ReadKey();