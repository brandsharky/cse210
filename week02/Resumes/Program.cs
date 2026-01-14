using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1.company = "Google";
        job1.jobTitle = "CEO";
        job1.startYear = 2025;
        job1.endYear = 2030;

        Job job2 = new Job();
        job2.company = "In-N-Out";
        job2.jobTitle = "CEO";
        job2.startYear = 2030;
        job2.endYear = 2040;


        Resume myResume = new Resume();
        myResume.name = "Brandon Arroyo";
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.DisplayResumeDetails();
    }
}