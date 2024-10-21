// Parsing

// prints whatever is inside of ()
Console.WriteLine("Enter a whole number!");

// initial declaration of the variable
int myNumber = 0;

// parse / convert string to an int
myNumber = int.Parse(Console.ReadLine());

//string myNumber = Console.ReadLine();
//myNumber = int.Parse(myNumber);

// appending variable onto a string
Console.WriteLine("You entered " + myNumber);
Console.WriteLine($"You entered {myNumber}");