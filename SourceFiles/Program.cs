using System;

namespace ComputerAverageApp
{
    class ComputerAverageApp
    {
        static void Main(string[] args)
        {
            // For some ~*personalization*~
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nWelcome! "+"Teacher "+userName);

            // Array to store the 5 grades
            int[] grades = new int[5];

            Console.WriteLine("\n=========================================\n" +
                "Enter 5 grades separated by a new line: ");

            // Loop to store automatically instead of writing code repeatedly
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Loop to add all the numbers in the array together
            double sumOfAll = 0; // <- Starting point
            for (int i = 0; i < grades.Length; i++)
            {
                sumOfAll += grades[i];
            }

            // calculating average
            double theAverage = (double) (sumOfAll/grades.Length);

            // rounding off
            int roundedOff = (int)Math.Round(theAverage);

            Console.WriteLine("=========================================\n"+
                "The average is "+ theAverage +" and rounds off to "+ roundedOff);
        }
    }
}
