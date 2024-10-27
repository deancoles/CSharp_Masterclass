// OR and NOT operators


bool isRainy = true;
bool hasUmbrella = true;

// Logical Operators
// OR || 
// NOT !


// OR operator, if at least one condition is true
/*if (isRainy || hasUmbrella)
{
    Console.WriteLine("I'm not getting wet");
}*/


// NOT operator takes a bool and negates a its value, returning the opposite value (true or false) instead
if (isRainy || !hasUmbrella)
{
    Console.WriteLine("I'm getting very wet");
}

Console.ReadKey();