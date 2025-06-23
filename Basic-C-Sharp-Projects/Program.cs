using System;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            // Step 1: Declare and initialize a one-dimensional array of strings
            // This array can represent any kind of base text, here we use example greetings
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Step 2: Ask the user to input some text
            Console.WriteLine("Please enter some text to append to each message:");
            string userInput = Console.ReadLine(); // Read user input from the console

            // Step 3: Use a loop to iterate through each element in the array
            // and append the user's input to the end of each string
            for (int i = 0; i < messages.Length; i++)
            {
                // Append the userInput to the current message
                messages[i] += " " + userInput; // Add a space between message and input
                // This step updates the array but does NOT output anything yet
            }

            // Step 4: Create a second loop to print each modified string in the array
            Console.WriteLine("\nUpdated messages:");
            foreach (string message in messages)
            {
                // Output each updated message one at a time
                Console.WriteLine(message);
            }

            // Pause the console so the user can see the output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 2

            // Step 1: Declare and initialize a one-dimensional array of strings
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Step 2: Infinite loop introduced here
            // Originally, this loop would run forever, which is NOT desirable
            // for a user-interactive console app. We'll fix it shortly.
            while (true) // INFINITE LOOP (initially)
            {
                // Step 3: Ask the user to input some text
                Console.WriteLine("\nPlease enter some text to append to each message (or type 'exit' to quit):");
                string userInput = Console.ReadLine(); // Read user input

                // FIX: Add a condition to break the infinite loop
                // If the user types "exit", we break the loop and end the program
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break; // Exit the loop
                }

                // Step 4: Loop through each element in the array and append the input
                for (int i = 0; i < messages.Length; i++)
                {
                    messages[i] += " " + userInput; // Append input to each string
                }

                // Step 5: Print all updated messages
                Console.WriteLine("\nUpdated messages:");
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }

                // The loop now repeats until the user types "exit"
            }

            // Final message after exiting the loop
            Console.WriteLine("\nProgram has ended. Press any key to close.");
            Console.ReadKey();
        }
    }
}
using System;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 3
            // Step 1: Declare and initialize a one-dimensional array of strings
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Step 2: Infinite loop introduced and FIXED with an exit condition
            while (true)
            {
                // Step 3: Ask the user to input some text
                Console.WriteLine("\nPlease enter some text to append to each message (or type 'exit' to quit):");
                string userInput = Console.ReadLine();

                // FIX: Break out of the infinite loop if user types 'exit'
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                // Step 4: Loop with '<' comparison operator
                // Demonstrates a for loop that runs strictly less than the array length
                Console.WriteLine("\nAppending user input using '<' loop:");
                for (int i = 0; i < messages.Length; i++) // using '<' operator
                {
                    messages[i] += " " + userInput;
                }

                // Step 5: Display updated messages
                Console.WriteLine("\nUpdated messages:");
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
using System;
using System.Collections.Generic;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 4
            // Step 1: Declare and initialize a one-dimensional array of strings
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Step 2: Create a list of unique strings
            List<string> uniqueWords = new List<string>
            {
                "Canada", "Programming", "VisualStudio", "OpenAI", "CSharp", "Console", "Loop", "Array"
            };

            // Step 3: Start an infinite loop (fixed with exit condition)
            while (true)
            {
                // Ask the user to input text or type 'exit'
                Console.WriteLine("\nPlease enter some text to append to each message (or type 'exit' to quit):");
                string userInput = Console.ReadLine();

                // Exit the loop if user types 'exit'
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                // Step 4: Use '<' operator to append input to each array message
                for (int i = 0; i < messages.Length; i++)
                {
                    messages[i] += " " + userInput;
                }

                // Step 5: Display updated messages
                Console.WriteLine("\nUpdated messages:");
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }

                // Step 6: Use '<=' operator to display indexes
                Console.WriteLine("\nDisplaying message indexes using '<=' loop:");
                int index = 0;
                while (index <= messages.Length - 1)
                {
                    Console.WriteLine($"Message index {index}: {messages[index]}");
                    index++;
                }

                // Step 7: Ask the user to search for a term in the unique list
                Console.WriteLine("\nSearch in the u
using System;
using System.Collections.Generic;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 5
            // Part 1: A one-dimensional array of strings (used in earlier steps)
            string[] messages = { "Hello", "Welcome", "Good day", "Hi", "Greetings" };

            // Part 2: A list of unique words (from earlier step)
            List<string> uniqueWords = new List<string>
            {
                "Canada", "Programming", "VisualStudio", "OpenAI", "CSharp", "Console", "Loop", "Array"
            };

            // Part 3: A list containing duplicates
            List<string> duplicateWords = new List<string>
            {
                "apple", "banana", "orange", "apple", "grape", "banana", "melon"
            };

            // Infinite loop to process user input until 'exit' is typed
            while (true)
            {
                Console.WriteLine("\nEnter text to append to each message (or type 'exit' to quit):");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                // Append user input to each message using '<' loop
                for (int i = 0; i < messages.Length; i++)
                {
                    messages[i] += " " + userInput;
                }

                // Display updated messages
                Console.WriteLine("\nUpdated messages:");
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }

                // Show message indexes using '<=' loop
                Console.WriteLine("\nDisplaying message indexes:");
                int index = 0;
                while (index <= messages.Length - 1)
                {
                    Console.WriteLine($"Message index {index}: {messages[index]}");
                    index++;
                }

                // Search functionality in list with duplicates
                Console.WriteLine("\nSearch in the list with duplicates. Please enter a word to search for:");
                string searchInput = Console.ReadLine();

                bool found = false; // Track if any match was found

                Console.WriteLine("\nSearching for matches in the duplicate list...");

                // Loop through the list and display all matching indices (no break)
                for (int i = 0; i < duplicateWords.Count; i++)
                {
                    if (duplicateWords[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Match found at index {i}: {duplicateWords[i]}");
                        found = true;
                    }
                }

                // If no matches were found
                if (!found)
                {
                    Console.WriteLine("The input text is not found in the duplicate list.");
                }

                // Optional: show the duplicate list
                Console.WriteLine("\nCurrent Duplicate List Items:");
                foreach (string item in duplicateWords)
                {
                    Console.WriteLine(item);
                }
            }

            // Program ends
            Console.WriteLine("\nProgram has ended. Press any key to close.");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;

namespace AppendTextToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 6
            // STEP 1: Define a list of strings that contains duplicates
            // For demonstration, we will detect duplicates using a foreach loop later
            List<string> names = new List<string>
            {
                "Alice", "Bob", "Charlie", "Alice", "David", "Bob", "Eve"
            };

            // STEP 2: Create a HashSet to track items that have already appeared
            // HashSet is efficient for checking if an item already exists
            HashSet<string> seenItems = new HashSet<string>();

            Console.WriteLine("Checking for duplicate items in the list:\n");

            // STEP 3: Use a foreach loop to evaluate each item in the list
            foreach (string name in names)
            {
                // Check if the item has already appeared in the HashSet
                if (seenItems.Contains(name))
                {
                    // If it exists, it's a duplicate
                    Console.WriteLine($"{name} - this item is a duplicate");
                }
                else
                {
                    // If not, it's unique and we add it to the HashSet
                    Console.WriteLine($"{name} - this item is unique");
                    seenItems.Add(name); // Add current name to the set of seen items
                }
            }

            // END: Pause the program before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
