using System;

public class ChecklistGoal : Goal
{
   private int _countRequired;
   private int _bonus;
   private int _timesCompleted;

   public ChecklistGoal(string name, string description, int points, int countRequired, int timesCompleted, int bonus) : base (name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetCountRequired(countRequired);
        SetTimesCompleted(timesCompleted);
        SetBonus(bonus);
    }

    public override void NewGoal()
    {
        Console.Write("Name of the goal: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("A brief description of this goal: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points for hitting this goal: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        Console.Write("Number of times for hitting the goal and get bonuses: ");
        int timesCompleted = int.Parse(Console.ReadLine());
        SetTimesCompleted(timesCompleted);
        Console.Write("Number of bonus points when you hit it that much: ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonus(bonus);
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public void SetCountRequired(int countRequired)
    {
        _countRequired = countRequired;
    }

    public override int GetCountRequired()
    {
        return _countRequired;
    }

    public override void SetBonus(int bonus)
    {
        _bonus= bonus;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void Completed()
    {
        _countRequired ++;
        Console.WriteLine($"Congratulations! You got {GetPoints()} points.");
        if (_countRequired == _timesCompleted)
        {
            Console.WriteLine($"Congratulations! You got {GetBonus()} as bonus points.");   
        }
    }
}