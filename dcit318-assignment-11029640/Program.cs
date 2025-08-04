using System;

namespace Assignment1
{
    class Program
    {

        static void GradeCalculator()
        {
            Console.Write("Enter your numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    return;
                }

                string letter = grade >= 90 ? "A" :
                                grade >= 80 ? "B" :
                                grade >= 70 ? "C" :
                                grade >= 60 ? "D" : "F";

                Console.WriteLine($"Your letter grade is: {letter}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void TicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                    return;
                }

                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

    }
}