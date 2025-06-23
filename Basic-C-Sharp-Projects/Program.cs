using System;

namespace MathOperationApp
{
    // This is our custom class where we'll define the method
    class MyMathClass
    {
        // This is a void method named DoMath
        // It takes two integer parameters: num1 and num2
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = num1 * 2;

            // Display the result of the operation
            Console.WriteLine($"Result of the math operation on the first number ({num1} * 2): {result}");

            // Display the second integer as requested
            Console.WriteLine($"The second number is: {num2}");
        }
    }

    // The main entry point of the console app
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MyMathClass
            MyMathClass mathObject = new MyMathClass();

            // Call the DoMath method using positional arguments
            Console.WriteLine("Calling DoMath with positional arguments:");
            mathObject.DoMath(5, 10); // 5 will be doubled, 10 will be displayed

            Console.WriteLine(); // Add a blank line for clarity

            // Call the DoMath method using named arguments
            Console.WriteLine("Calling DoMath with named arguments:");
            mathObject.DoMath(num2: 20, num1: 7); // 7 will be doubled, 20 will be displayed

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
