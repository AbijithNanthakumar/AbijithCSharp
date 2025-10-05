using System;

namespace CustomExceptionDemo
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be at least 18.");
            }
            else
            {
                Console.WriteLine("Access granted. Age is valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Validation process completed.");
            }

            Console.WriteLine("Program continues...");
        }
    }
}
