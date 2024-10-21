// String Interpolation is a method to use strings and variables in a sentence with a neater format than Concatination

Console.WriteLine("Please enter your name");

// declaration of name
string myName = Console.ReadLine();

Console.WriteLine("Please enter your age");

// declaration of age
string myAge = Console.ReadLine();

Console.WriteLine("Please enter your gender");

// declaration of gender
string myGender = Console.ReadLine();

// string concatenation
Console.WriteLine("Hello there " + myName + ", I can see that you are a " + myAge + "year old " + myGender);

// string interpolation
Console.WriteLine($"Hello there {myName}, I can see that you are a {myAge} year old {myGender}");
