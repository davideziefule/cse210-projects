
using System;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVE ADDITION:
        // This program includes a memorization progress indicator.
        // It shows the percentage of words hidden and the number
        // of words remaining. It also selects only words that
        // have not already been hidden.

        Reference reference = new Reference(
            "Proverbs",
            3,
            5,
            6
        );

        string scriptureText =
            "Trust in the Lord with all thine heart; and lean not " +
            "unto thine own understanding. In all thy ways " +
            "acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            scripture.Display();

            int progress = scripture.GetProgress();

            int hidden = scripture.GetHiddenWordCount();

            int total = scripture.GetTotalWordCount();

            Console.WriteLine($"Memorization progress: {progress}%");
            Console.WriteLine($"Words hidden: {hidden} of {total}");
            Console.WriteLine($"Words remaining: {total - hidden}");

            Console.WriteLine();

            Console.WriteLine(
                "Press ENTER to hide more words or type 'quit' to exit:"
            );

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();

        scripture.Display();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Congratulations! You have hidden all the words.");
            Console.WriteLine("Keep practicing until you can recite the scripture!");
        }
    }
}
