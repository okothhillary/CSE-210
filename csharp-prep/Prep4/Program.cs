using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Append-ix only that we use .Add");

        List<int> numbers = new List<int>();
        
        int reply = -1;

        while (reply != 0)
        {
            Console.Write("Give me a number: ");
            reply = int.Parse(Console.ReadLine());

            numbers.Add(reply);    

                       
        }
        int sum = 0;
            foreach (int num in numbers)

            {                
                sum += num;
            }

        Console.WriteLine($"Sum of numbers in that list: {sum}"); 

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}      