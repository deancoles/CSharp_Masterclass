// Incrementing and Pre-Incrementing

int num = 0;

Console.WriteLine($"Num is {num}");

// incrementing of the int
num++;

Console.WriteLine($"Num is {num}");     // Interpolation

// pre-incrementing
Console.WriteLine("Num is {0}", ++num); // String Formatting, incrementing happens before the variable
Console.WriteLine("Num is {0}", num++); // String Formatting, incrementing happens after the variable
Console.WriteLine("Num is {0}",num);    // The incrementation from the previous line now displays

Console.ReadKey();