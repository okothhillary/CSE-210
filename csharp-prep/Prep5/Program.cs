using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Here we Go!");            
        }

    static string PromptUserName()
    {
        Console.Write("Type Username: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Give me a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        
        int squareNumber = userNumber * userNumber;

        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"Hi, {userName}. Your number squared is{squareNumber}.");
    }

}
