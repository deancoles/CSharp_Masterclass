// Decrementing

int num = 0;
Console.WriteLine($"Num is {num}");

// incrementing of the int
num++;
Console.WriteLine($"Num is {num}");     // Interpolation

// pre-incrementing
Console.WriteLine("Num is {0}", ++num); // String Formatting, incrementing happens before the variable
Console.WriteLine("Num is {0}", num++); // String Formatting, incrementing happens after the variable
Console.WriteLine("Num is {0}", num);   // The incrementation from the previous line now displays

// decrementing
num--;
Console.WriteLine("Num is {0}", num);
Console.WriteLine("Num is {0}", --num); // String Formatting, decrementing happens before the variable
Console.WriteLine("Num is {0}", num--); // String Formatting, decrementing happens after the variable
Console.WriteLine("Num is {0}", num);   // The decrementation from the previous line now displays

// incrementing and decrementing by specific number
num += 30;
Console.WriteLine("Num is {0}", num);
num -= 10;
Console.WriteLine("Num is {0}", num);

Console.ReadKey();

