using System;

using System;

public class ListingActivity : Activity
{


    private string _description = "List what you are grateful for. You will be surprised!";
    private string _activityName = "Listing Activity";

    private List<string> _userResponses = new List<string>();

    public ListingActivity()
    {
        _prompts.Add("My favourite people in the world: ");
        _prompts.Add("Something that you're the best at in the world...");
        _prompts.Add("Did I serve anyone today?");
        _prompts.Add("A strong prompt that really made my bosom burn...");
        _prompts.Add("People that I really look up to?");
    }

    public void AddList(int timer)
    {
        ShowPrompt();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);
        while (VerifyTime(timer, futureTime))
        {
            _userResponses.Add(UserResponses());
        }
        Console.WriteLine($"You listed {_userResponses.Count} items");

    }
    public void ShowPrompt()
    {
        GetReady(2);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string randomPrompt = SelectRandomItem(_prompts);
        Console.WriteLine($"---- {randomPrompt} ----");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
    }


    public string UserResponses()
    {
        Console.Write("> ");
        string answer = Console.ReadLine();
        return answer;
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