using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade:");
        string response = Console.ReadLine();
        int gradeResponse = int.Parse(response);

        string letter = "A";

        if (gradeResponse > 90 || gradeResponse == 90)
            {
                letter = "A";
            }
            else if (gradeResponse > 80 || gradeResponse == 80)
            {
                letter ="B";
            }
            else if (gradeResponse > 70 || gradeResponse == 70)
            {
                letter = "C";
            }
            else if (gradeResponse > 60 || gradeResponse == 60)
            {
                letter = "D";
            }
            else if (gradeResponse < 60 )
            {
                letter = "F";
            }

        
        
        Console.WriteLine($"Your grade is {letter}.");    

        if (gradeResponse < 70)
            {
                Console.WriteLine("You failed.");
            }
        else
        {
            Console.WriteLine("You passed.");
        }
    }
}