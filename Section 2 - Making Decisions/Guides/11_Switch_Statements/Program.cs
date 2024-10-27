// Switch Statement


Console.WriteLine("Please enter a number between 1 and 12");
int month = int.Parse(Console.ReadLine());
string monthName;


switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:                        // Switch equivalent of an ELSE
        monthName = "Unknown";
        break;
}

Console.WriteLine($"The month you selected is {monthName}.");