using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        RunningActivity runningActivity = new RunningActivity(3, 30, 6000);
        CyclingActivity cyclingActivity = new CyclingActivity(10, 45, 2000);
        SwimmingActivity swimmingActivity = new SwimmingActivity(30, 25);

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
