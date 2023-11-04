using System;

public class ReflectingActivity : Activity
{


    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _activityName = "Reflecting Activity";


    public ReflectingActivity()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful ?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Reflect(int timer)

    {
        ShowPrompt();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);
        while (VerifyTime(timer, futureTime))
        {
            ShowQuestion();
        }

    }

    public void ShowPrompt()
    {

        GetReady(2);
        Console.WriteLine();
        Console.WriteLine("Think about this (you gotta focus, no tiktok!):");

        string randomPrompt = SelectRandomItem(_prompts);
        Console.WriteLine();
        Console.WriteLine($" --- {randomPrompt} ---");

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Think deeply about these questions: ");

        Console.WriteLine("You may begin in: ");
        CountDown(7);
        Console.Clear();
    }



    public void ShowQuestion()
    {
        string randomQuestion = SelectRandomItem(_questions);
        Console.WriteLine();
        Console.Write($"> {randomQuestion}");
        Spinner(8);
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }

}