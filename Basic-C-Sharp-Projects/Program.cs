using System;

namespace InterfacePolymorphismApp
{
    // STEP 1: Define the interface named IQuittable
    // It declares a void method called Quit
    public interface IQuittable
    {
        void Quit(); // No implementation here; it's just a contract
    }

    // STEP 2: Define the Employee class
    // It inherits from IQuittable, meaning it must implement Quit()
    public class Employee : IQuittable
    {
        // Some example properties of Employee
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize the employee
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // STEP 3: Implement the Quit method from IQuittable
        public void Quit()
        {
            // Display a custom quit message
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    // Main program entry point
    class Program
    {
        static void Main(string[] args)
        {
            // STEP 4: Create an Employee object
            Employee emp = new Employee("John", "Doe");

            // STEP 5: Use polymorphism
            // Create an object of type IQuittable and assign the Employee instance to it
            IQuittable quittableEmployee = emp;

            // STEP 6: Call the Quit method using the interface type reference
            quittableEmployee.Quit();

            // Pause before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
