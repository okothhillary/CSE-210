using System;

public class SimpleGoal : Goal 
{
  
  public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetCompleted(completed);
    }

    public override void NewGoal()
    {
        Console.Write("What goal are you setting? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("Tell me about it in less than 30 characters: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points for this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        SetCompleted(false);
    }

    public override void Completed()
    {
        Console.WriteLine($"Well done! You got {GetPoints()} points.");
        SetCompleted(true);
    }
}