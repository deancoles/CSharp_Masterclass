// Create a program that allows for the input of two numbers and adds them together

// declares the two integers
double myNumber1 = 0;
double myNumber2 = 0;

// the entry of the two numbers
Console.WriteLine("Enter a number");
myNumber1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
myNumber2 = double.Parse(Console.ReadLine());

// the calculation
double finalAnswer = myNumber1 + myNumber2;

// rounds the answer to two decimal places
finalAnswer = Math.Round(finalAnswer, 2);

// the console prints the answer
Console.WriteLine("Now lets add these two numbers together!");
Console.WriteLine($"{myNumber1} + {myNumber2} = {finalAnswer}");