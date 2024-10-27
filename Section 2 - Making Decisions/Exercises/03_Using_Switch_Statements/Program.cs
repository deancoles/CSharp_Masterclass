// Create a simple C# program using a switch statement for printing days of the week based on an integer value.

// User inputs a number
Console.WriteLine("Please enter a whole number between 1 and 7.");
int day = int.Parse(Console.ReadLine());
string dayName;

// A Switch Statement to return a day of the week
switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid Day";
        break;
}

Console.WriteLine($"You chose {dayName}");





