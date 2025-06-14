using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight exceeds the allowed limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt for package width
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt for package height
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt for package length
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate total dimensions
        double dimensionTotal = width + height + length;

        // Check if dimension total exceeds the limit
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the quote: (Width * Height * Length * Weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the final quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
