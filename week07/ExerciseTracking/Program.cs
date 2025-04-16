using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running { Date = "03 Nov 2022", Duration = 30, Distance = 3.0 });

        activities.Add(new Cycling { Date = "04 Nov 2022", Duration = 45, Speed = 12.0 });

        activities.Add(new Swimming { Date = "05 Nov 2022", Duration = 40, Laps = 30 });

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
