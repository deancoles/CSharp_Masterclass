// Create a simple C# program that uses a boolean variable to store whether a user is logged in and prints different messages based on the value. 
// The final output must be "Welcome back!" The result of execution for the default string should be: "Welcome back!"


// Assigns a value to isLoggedIn based on user input or condition
bool isLoggedIn;

// Asks user for their input with the answer converted to an upper case character
Console.WriteLine("Hello are you logged in?/n Please enter a 'Y' for yes and a 'N' for no");
string answer = Console.ReadLine().ToUpper();

// Decides the bool value 
if (answer == "Y")
{
    isLoggedIn = true;
}
else
{
    isLoggedIn = false;
}

// The response
if (isLoggedIn)
{
Console.WriteLine("Welcome back!");
}
else
{
Console.WriteLine("Please log in.");
}