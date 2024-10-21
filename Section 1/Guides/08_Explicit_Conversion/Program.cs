// explicit conversion is when you forceably change the data type to another, this can cause data loss if the programmer isn't careful

// declaration of a long
long myLongOriginal = 132345098312389012;
long myLong = 132345098312389012;

// explicit conversion, this forces the conversion to an int causing a loss of data once it reaches its limit
int myInt = (int)myLong;
Console.WriteLine(myInt);
Console.WriteLine($"There is data loss here as we should see the number {myLongOriginal} but instead get {myInt} due to the limits of ints compared with long.");

// declaration of a long which has less data
long myLong2 = 1323450;

// explicit conversion, this forces the conversion to an int causing no loss of data since it is within the limitations of an int
int myInt2 = (int)myLong2;
Console.WriteLine(myInt2);
Console.WriteLine("There is no loss of data here as the original data fits the limits of the int data type.");

Console.ReadKey();
