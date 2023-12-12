using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        RunningActivity runningActivity = new RunningActivity(5, 20, 3000);
        CyclingActivity cyclingActivity = new CyclingActivity(7, 30, 1800);
        SwimmingActivity swimmingActivity = new SwimmingActivity(28, 15);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
