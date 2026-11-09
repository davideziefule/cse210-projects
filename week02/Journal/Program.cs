
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Journal object
        Journal journal = new Journal();

        string choice = "";

        // EXTRA FEATURE DESCRIPTION:
        // This program includes a Writing Progress Tracker.
        // It counts the words in each journal response and
        // encourages users to reach a goal of 50 words per entry.
        // This feature helps users develop a consistent
        // journaling habit and encourages deeper reflection.

        while (choice != "5")
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("          DAILY JOURNAL");
            Console.WriteLine("================================");

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");
            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                journal.WriteEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.LoadEntries();
            }
            else if (choice == "4")
            {
                journal.SaveEntries();
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nThank you for using Daily Journal!");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
            }
        }
    }
}
