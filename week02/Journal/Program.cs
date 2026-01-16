/*
Journal Program

Brandon Arroyo
1/15/2026

Enhancements: Each journal entry also records the user's mood for the day. The program automatically calculates and stores a word count for each journal response. This helps the user reflect on their emotions and journaling consistency with increasing the pressure to write.
*/

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        bool running = true;


        while (running)
        {
            Console.WriteLine("\n|===== Journal Menu =====|\n");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5: Quit\n");

            Console.Write("Choose an option:\n> ");
            string userChoice = Console.ReadLine().ToLower();



            switch (userChoice)
            {
                case "1":
                    string prompt = promptGenerator.GenerateRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("How would you describe your overall mood for today? ");
                    string mood = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(entry);

                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write($"Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);

                    break;

                case "4":
                    Console.Write("Enter a filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);

                    break;

                case "5" or "q":
                    Console.WriteLine($"You chose to quit.");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nHave a nice day!");
    }
}