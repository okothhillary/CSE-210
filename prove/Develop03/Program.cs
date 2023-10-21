using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("Matthew", "2", "1", "2");
        Reference oneVerseReference = new Reference("Matthew", "2", "1");
        Scripture scripture1 = new Scripture(reference, "Now when Jesus was born in Bethlehem of Judæa in the days of Herod the king, behold, there came wise men from the east to Jerusalem. Saying, Where is he that is born King of the Jews? for we have seen his star in the east, and are come to worship him");
        Scripture scripture2 = new Scripture(oneVerseReference, "Now when Jesus was born in Bethlehem of Judæa in the days of Herod the king, behold, there came wise men from the east to Jerusalem.");

        string line = "";

        while(line != "quit")
        {
            Console.Clear();
            scripture1.Display();
            if (scripture1.isCompletelyHidden())
            {
                line = "quit";
                break;
            }
            Console.WriteLine("\n\nPress enter to continue and hide words or type quit.");
            line = Console.ReadLine();
            scripture1.HideWords();
        }


    }
}