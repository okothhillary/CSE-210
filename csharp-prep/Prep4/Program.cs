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
       
    }
}