// Else If and Order of Importance

int age = 16;
bool isWithParents = true;

// Will check the conditions from top to bottom, once it finds a matching condition it will execute and then stop looking
if(age >= 13 && isWithParents)
{
    Console.WriteLine("Party like it's 1999! with your parents");
}
else if (age >= 18)
{
    Console.WriteLine("Go party in the club");
}
else
{
    Console.WriteLine("No fun for you!");
}

Console.ReadKey();