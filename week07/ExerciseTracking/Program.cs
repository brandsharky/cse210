using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activites = new List<Activity>();

        activites.Add(new Running(new DateTime(2026, 11, 3), 30, 1));
        activites.Add(new Cycling(new DateTime(2026, 11, 4), 60, 15.0));
        activites.Add(new Swimming(new DateTime(2026, 11, 5), 120, 40));

        foreach (Activity activity in activites)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}