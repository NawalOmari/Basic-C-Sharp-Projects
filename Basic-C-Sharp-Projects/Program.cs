using System;

namespace EmployeeComparisonApp
{
    // STEP 1: Define the Employee class
    public class Employee
    {
        // Properties to store basic employee details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // STEP 2: Overload the '==' operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            // Compare their Id properties
            return emp1.Id == emp2.Id;
        }

        // STEP 3: Overload the '!=' operator (must be done in a pair with '==')
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the previously defined '==' operator and negate the result
            return !(emp1 == emp2);
        }

        // STEP 4: Override Equals and GetHashCode for completeness and compiler warning suppression
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare Ids
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // STEP 5: Program entry point
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Smith"
            };

            // Create the second Employee object with different or same Id
            Employee employee2 = new Employee
            {
                Id = 101, // Try changing to a different number to test '!='
                FirstName = "Bob",
                LastName = "Johnson"
            };

            // STEP 6: Compare the two employee objects using the overloaded '==' operator
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are considered equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are NOT equal (different Ids).");
            }

            // STEP 7: Also demonstrate the '!=' operator
            if (employee1 != employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are different based on Id.");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same based on Id.");
            }

            // Pause to see output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
