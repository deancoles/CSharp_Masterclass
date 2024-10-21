// Create a program that allows for the input of two whole numbers and adds them together

// declares the two integers
int myNumber1 = 0;
int myNumber2 = 0;

// the entry of the two whole numbers which are input as strings and converted to int
Console.WriteLine("Enter a whole number");
myNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter another whole number");
myNumber2 = int.Parse(Console.ReadLine());

// the calculation
int finalAnswer = myNumber1 + myNumber2;

// the console prints the answer
Console.WriteLine("Now lets add these two numbers together!");
Console.WriteLine($"{myNumber1} + {myNumber2} = {finalAnswer}");