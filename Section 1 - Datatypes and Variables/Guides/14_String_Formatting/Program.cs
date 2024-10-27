// String Formatting

int num = 10;
double price = 19.95;
string name = "Dean";

// String Concatenation
Console.WriteLine("The number is " + num);

// String Interpolation
Console.WriteLine($"The number is {num}");

// String Formatting, numbers indicate the position of the variables at the end of the WriteLine
Console.WriteLine("The number is {0}, the price is {1}, and the name is {2}", num, price, name);

Console.ReadKey();