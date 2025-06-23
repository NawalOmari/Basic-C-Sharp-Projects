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
