// Conversion Helpers Parse and Convert
// Parse will only accept strings

// will convert the string to an int as long as it contains only numbers
string numberString = "123";
int result = int.Parse(numberString);

// will convert string to bool as long as variable value is "true" or "false"
string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine($"My bool is {myBool}");


Console.ReadKey();