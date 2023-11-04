using System;
using System.Threading;

public class Activity
{

    protected string _welcomeMessage = "YOUR MINDFULNESS PROGRAMME";

    protected List<string> _spinner = new List<string>();

    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();


    public void GetIntro(string activityName, string description)
    {

        Console.Clear();
        Console.WriteLine(_welcomeMessage + activityName);
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

    }

    public void Menu()
    {
        Console.Clear();

        Console.WriteLine("   Menu: \n");
        Console.WriteLine("   1. Take my breath away");
        Console.WriteLine("   2. Some Deep Moment of introspection");
        Console.WriteLine("   3. Things I want to remember");
        Console.WriteLine("   4. Take a Break");
        Console.Write("\n   Type in a number representing your choice from the menu: ");

    }
    //the spinner: animation that displays when loading
    public void Spinner(int seconds)
    {

        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            
            Console.Write("\b \b");
            i++;
            

            if (i >= _spinner.Count)
            {
                i = 0;
            }
            
        }
    }
    public void GetReady(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(seconds);
        Console.WriteLine();
    }


    public int Time()
    {
        Console.Write("How may seconds for this session: ");
        int howLongTime = Convert.ToInt32(Console.ReadLine());
        return howLongTime;
    }


    public bool VerifyTime(int timer, DateTime futuretime)
    {

        if (DateTime.Now < futuretime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected string SelectRandomItem(List<string> list)
    {

        Random randomGenerator = new Random();

        int randomprompt = randomGenerator.Next(0, list.Count);
        string prompt = list[randomprompt];
        return prompt;
    }


    public void CountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetOutro(int seconds, string activity)
    {
        Console.WriteLine();
        Console.WriteLine("PERFECT!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {seconds} seconds of the {activity}");
        Spinner(7);

    }

}