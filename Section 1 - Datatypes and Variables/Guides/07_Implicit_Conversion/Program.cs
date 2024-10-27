// implicit conversion is when you change the data type to something which is able to contain that information 

// int to double is implicit because a double can take all int values
int myInt = 13;
double myDouble = myInt;

// int to long is implicit because a long is a bigger version of the int (being 64 bit compared to 32)
long myLong = myInt;

// will not work as an int is smaller than a long causing data loss
// myInt = myLong;

// will work as a double is larger than a float
float myFloat = 123.123f;
myDouble = myFloat;

Console.ReadKey();

