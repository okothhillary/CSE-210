using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }

    public override void NewGoal()
    {
        Console.Write("Name of the goal that you are setting: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("A short description of it: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("Number of points when you hit this goal: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }

    public override void Completed()
    {
        Console.WriteLine($"Sweet! You got{GetPoints()} points!");
        SetCompleted(true);
    }
}