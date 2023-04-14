// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            double equivalent = 0;
            Console.WriteLine("Enter the grade: ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 97 && grade <= 100)
            {
                Console.WriteLine("Your equivalent grade is 1.0.");
                equivalent = 1.0;
            }
            else if (grade >= 94 && grade <= 96)
            {
                Console.WriteLine("Your equivalent grade is 1.25.");
                equivalent = 1.25;
            }
            else if (grade >= 91 && grade <= 93)
            {
                Console.WriteLine("Your equivalent grade is 1.50.");
                equivalent = 1.50;
            }
            else if (grade >= 88 && grade <= 90)
            {
                Console.WriteLine("Your equivalent grade is 1.75.");
                equivalent = 1.75;
            }
            else if (grade >= 85 && grade <= 87)
            {
                Console.WriteLine("Your equivalent grade is 2.0.");
                equivalent = 2.0;
            }
            else if (grade >= 82 && grade <= 84)
            {
                Console.WriteLine("Your equivalent grade is 2.25.");
                equivalent = 2.25;
            }
            else if (grade >= 79 && grade <= 81)
            {
                Console.WriteLine("Your equivalent grade is 2.50.");
                equivalent = 2.50;
            }
            else if (grade >= 76 && grade <= 78)
            {
                Console.WriteLine("Your equivalent grade is 2.75.");
                equivalent = 2.75;
            }
            else if (grade == 75)
            {
                Console.WriteLine("Your equivalent grade is 3.0.");
                equivalent = 3.0;
            }
            else
            {
                Console.WriteLine("Your equivalent grade is 4.0.");
                equivalent = 4.0;
            }

            switch (equivalent)
            {
                case 1.0 or 1.25:
                    Console.WriteLine("Excellent!");
                    break;
                case 1.5 or 1.75:
                    Console.WriteLine("Very Good");
                    break;
                case 2.0 or 2.25:
                    Console.WriteLine("Good");
                    break;
                case 2.5 or 2.75:
                    Console.WriteLine("Satisfactory");
                    break;
                case 3.0:
                    Console.WriteLine("Passing");
                    break;
                case 4.0:
                    Console.WriteLine("Conditional");
                    break;
                default:
                    Console.WriteLine("I'm sorry. You failed.");
                    break;

            }
        }
    }
}
