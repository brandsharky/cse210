/*
Homework Program

Brandon Arroyo
2/2/2025
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Brandon Arroyo", "Programming with Classes");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Brandon Arroyo", "Integrals", "5.5", "1-22");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Brandon Arroyo", "World History", "Causes of WWII");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}