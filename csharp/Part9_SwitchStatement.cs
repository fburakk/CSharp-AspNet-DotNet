using System;

//Switch Statement
class Program
{
    public static void Main()
    {

        Console.WriteLine("Please enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", UserNumber);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 & 30");
                break;
        }

        goto;
        int TotalCoffeCost = 0;
    Start:
        Console.WriteLine("Select coffe you want, 1-Small 2-Medium 3-Big");
        int UserChoice = int.Parse(Console.ReadLine());
        switch (UserChoice)
        {
            case 1:
                TotalCoffeCost += 1;
                break;
            case 2:
                TotalCoffeCost += 2;
                break;
            case 3:
                TotalCoffeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice is invalid", UserChoice);
                goto Start;
        }

    Decision:
        Console.WriteLine("Do you want to by another coffe - Yes or No");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Invalid choice! try again");
                goto Decision;
        }

        Console.WriteLine("Thank you for your shopping!");
        Console.WriteLine("Bill amount  {0}", TotalCoffeCost);
    }
}