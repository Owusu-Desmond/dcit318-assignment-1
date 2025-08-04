using System;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Assignment 1 Menu");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }

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

        static void TriangleTypeIdentifier()
        {
            Console.WriteLine("Enter the three sides of the triangle:");

            Console.Write("Side 1: ");
            bool valid1 = double.TryParse(Console.ReadLine(), out double side1);
            Console.Write("Side 2: ");
            bool valid2 = double.TryParse(Console.ReadLine(), out double side2);
            Console.Write("Side 3: ");
            bool valid3 = double.TryParse(Console.ReadLine(), out double side3);

            if (!valid1 || !valid2 || !valid3 || side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive numbers.");
                return;
            }

            if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("This is an Equilateral triangle.");
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    Console.WriteLine("This is an Isosceles triangle.");
                else
                    Console.WriteLine("This is a Scalene triangle.");
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }
    }
}