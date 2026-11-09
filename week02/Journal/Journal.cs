
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // Collection of journal entries
    private List<Entry> _entries = new List<Entry>();

    // Collection of writing prompts
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "What did I learn today?",
        "What could I have done better today?",
        "What is something I am grateful for?",
        "What challenge did I overcome today?",
        "What is one thing I want to accomplish tomorrow?",
        "When did I feel most productive today?",
        "What is something new I discovered today?",
        "What decision did I make today?",
        "How did I help someone today?"
    };

    // Random number generator
    private Random _random = new Random();

    // Write a new journal entry
    public void WriteEntry()
    {
        // Select a random writing prompt
        int index = _random.Next(_prompts.Count);

        string selectedPrompt = _prompts[index];

        // Display the selected prompt
        Console.WriteLine("\nWriting Prompt:");
        Console.WriteLine(selectedPrompt);

        // Collect the user's response
        Console.Write("\nYour response: ");
        string response = Console.ReadLine() ?? "";

        // Capture the current date
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

        // Create a new Entry object
        Entry newEntry = new Entry(date, selectedPrompt, response);

        // Add the entry to the collection
        _entries.Add(newEntry);

        Console.WriteLine("\nJournal entry added successfully!");

        // EXTRA FEATURE: Writing Progress Tracker
        // Count the words in the user's response
        int wordCount = response.Split(
            (char[])null,
            StringSplitOptions.RemoveEmptyEntries
        ).Length;

        Console.WriteLine("\nWords written: " + wordCount);

        // Encourage the user to reach the 50-word goal
        if (wordCount >= 50)
        {
            Console.WriteLine(
                "Excellent! You reached your 50-word writing goal!"
            );
        }
        else
        {
            Console.WriteLine(
                "Good start! Try to reach 50 words in your next entry."
            );
        }
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        Console.WriteLine("\n========== MY JOURNAL ==========");

        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        Console.WriteLine("\nTotal Entries: " + _entries.Count);

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    // Save all journal entries to a file
    public void SaveEntries()
    {
        Console.Write("Enter the file name to save: ");
        string fileName = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Please enter a valid file name.");
            return;
        }

        try
        {
            // Convert journal entries into JSON format
            string json = JsonSerializer.Serialize(
                _entries,
                new JsonSerializerOptions { WriteIndented = true }
            );

            // Create or overwrite the selected file
            File.WriteAllText(fileName, json);

            Console.WriteLine("Journal saved successfully!");
            Console.WriteLine("Total entries saved: " + _entries.Count);
        }
        catch (IOException)
        {
            Console.WriteLine("Unable to save the journal file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to save this file.");
        }
    }

    // Load journal entries from a file
    public void LoadEntries()
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Please enter a valid file name.");
            return;
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please check the filename.");
            return;
        }

        try
        {
            // Read the selected file
            string json = File.ReadAllText(fileName);

            // Reconstruct Entry objects from JSON
            List<Entry>? loadedEntries =
                JsonSerializer.Deserialize<List<Entry>>(json);

            if (loadedEntries == null)
            {
                Console.WriteLine("Invalid journal file.");
                return;
            }

            // Add loaded entries to the journal collection
            _entries.AddRange(loadedEntries);

            Console.WriteLine("Journal loaded successfully!");
            Console.WriteLine(
                "Total entries loaded: " + loadedEntries.Count
            );
        }
        catch (JsonException)
        {
            Console.WriteLine("The selected file contains invalid journal data.");
        }
        catch (IOException)
        {
            Console.WriteLine("Unable to read the journal file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to read this file.");
        }
    }
}
