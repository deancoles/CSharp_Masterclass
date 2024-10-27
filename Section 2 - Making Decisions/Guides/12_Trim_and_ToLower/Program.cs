// Trim and ToLower

string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())    // Trim() removes empty spaces from beginning and end, ToLower() converts string to lowercase
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine($"Incorrect. The capital is {answer1}");
}
