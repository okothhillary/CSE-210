using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int setNumber = randomGenerator.Next(1, 101);
        int reply = -1;

        while (reply != setNumber)

        {

            Console.Write("Guess a single digit number: ");
            reply = int.Parse(Console.ReadLine());

            
            if(reply > setNumber)
            {
                Console.Write("Guess a lower number: ");
                
            }
            else if (reply < setNumber)
            {
                Console.Write("Guess Higher: ");
            } 
            else
            {
                Console.WriteLine("You guessed the right number!");
            }   
                        
        }
        

        
    }
}