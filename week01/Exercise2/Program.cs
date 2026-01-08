using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int remainder = grade % 10;
        if (grade < 93 && grade > 60)
        {
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3 && remainder > 0)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congragulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class. Better luck next time.");
        }
    }
}