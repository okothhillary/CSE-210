using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        RunningActivity runningActivity = new RunningActivity(4, 25, 4500);
        CyclingActivity cyclingActivity = new CyclingActivity(17, 48, 1800);
        SwimmingActivity swimmingActivity = new SwimmingActivity(25, 10);

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
