// Create a basic Quiz application

// Questions to Use
string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";
string question2 = "What is 2 + 2";
string answer2 = "4";
string question3 = "What colour to you get by mixing blue and yellow";
string answer3 = "Green";

// User score
int score = 0;

// Question 1
Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1 == answer1)
{
    Console.WriteLine("Correct!");
    score = score+1;
}
else
{
    Console.WriteLine($"Incorrect. The capital is {answer1}");
}

// Question 2
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine($"Incorrect. The capital is {answer2}");
}

// Question 3
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine($"Incorrect. The capital is {answer3}");
}

// User receives final total
Console.WriteLine($"Your final score is {score}/3");
if (score == 3)
{
    Console.WriteLine("Congratualations, you got all questions correct!");
}
else if (score >= 1)
{
    Console.WriteLine("Good job, but try again ");
}
else
{
    Console.WriteLine("Let's get some right next time!");
}

Console.ReadKey();