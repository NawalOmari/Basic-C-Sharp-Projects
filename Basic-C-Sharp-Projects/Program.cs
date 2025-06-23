using System;
using System.Collections.Generic;

namespace CombinedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create and initialize a one-dimensional array of strings
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Step 2: Create a list of unique strings
            List<string> uniqueList = new List<string>
            {
                "Canada", "Programming", "VisualStudio", "OpenAI", "CSharp", "Console", "Loop", "Array"
            };

            // Step 3: Create a list with duplicates for match search and evaluation
            List<string> duplicateList = new List<string>
            {
                "apple", "banana", "orange", "apple", "grape", "banana", "melon"
            };

            // Step 4: Create another list with duplicates for foreach duplicate evaluation
            List<string> checkDuplicates = new List<string>
            {
                "A", "B", "C", "D", "C"
            };

            // Step 5: Begin infinite loop to allow repeated user interaction
            while (true)
            {
                Console.WriteLine("\n=== APPEND TEXT TO MESSAGES ===");
                Console.WriteLine("Enter text to append to each message (or type 'exit' to quit):");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break; // Exit the loop and end the program
                }

                // Append the user's input to each message using a loop with '<' operator
                for (int i = 0; i < messages.Length; i++)
                {
                    messages[i] += " " + userInput;
                }

                // Print each updated message using a foreach loop
                Console.WriteLine("\nUpdated Messages:");
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }

                // Display array indexes using a while loop with '<=' operator
                Console.WriteLine("\nMessage Indexes:");
                int index = 0;
                while (index <= messages.Length - 1)
                {
                    Console.WriteLine($"Message index {index}: {messages[index]}");
                    index++;
                }

                // Step 6: Search the unique list for one match and break on first match
                Console.WriteLine("\n=== SEARCH IN UNIQUE LIST ===");
                Console.WriteLine("Enter a term to search (only the first match will be shown):");
                string searchTerm = Console.ReadLine();
                bool foundUnique = false;

                for (int i = 0; i < uniqueList.Count; i++)
                {
                    if (uniqueList[i].Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Match found at index {i}: {uniqueList[i]}");
                        foundUnique = true;
                        break; // Stop at the first match
                    }
                }

                if (!foundUnique)
                {
                    Console.WriteLine("The input text is not found in the unique list.");
                }

                // Step 7: Search duplicate list for all matches (no break)
                Console.WriteLine("\n=== SEARCH ALL MATCHES IN DUPLICATE LIST ===");
                Console.WriteLine("Enter a word to search for in the list (all matches will be shown):");
                string duplicateSearch = Console.ReadLine();
                bool foundDuplicate = false;

                for (int i = 0; i < duplicateList.Count; i++)
                {
                    if (duplicateList[i].Equals(duplicateSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Match found at index {i}: {duplicateList[i]}");
                        foundDuplicate = true;
                    }
                }

                if (!foundDuplicate)
                {
                    Console.WriteLine("The input text is not found in the duplicate list.");
                }

                // Step 8: Use foreach loop to detect duplicates in another list
                Console.WriteLine("\n=== DUPLICATE CHECK USING FOREACH ===");
                HashSet<string> seenItems = new HashSet<string>(); // Track seen items

                foreach (string item in checkDuplicates)
                {
                    if (seenItems.Contains(item))
                    {
                        Console.WriteLine($"{item} - this item is a duplicate");
                    }
                    else
                    {
                        Console.WriteLine($"{item} - this item is unique");
                        seenItems.Add(item); // Track it as seen
                    }
                }

                // Ask the user if they want to run again or exit
                Console.WriteLine("\nPress Enter to repeat or type 'exit' to quit:");
                string nextAction = Console.ReadLine();
                if (nextAction.ToLower() == "exit") break;
            }

            // End of the program
            Console.WriteLine("\nProgram has ended. Press any key to close.");
            Console.ReadKey();
        }
    }
}
