using System;
using System.Collections.Generic;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            getAverage(getInput());
        }

        private static double[] getInput()
        {
            String[] subjects = { "English", "Math", "Science", "Filipino", "History" };
            List<double> grades = new List<double>();
            Console.WriteLine("Enter Grades");

            int index = 0;
            while (grades.Count < subjects.Length)
            {
                double input;
                Console.WriteLine(subjects[index] + " : ");
                if (double.TryParse(Console.ReadLine(), out input))
                {
                    grades.Add(input);
                    index++;
                }
                else Console.WriteLine("Please enter a valid number");
            }
            return grades.ToArray();
        }

        private static void getAverage(double[] grades)
        {
            double average = 0;
            foreach (double grade in grades) average += grade;
            average /= grades.Length;
            Console.WriteLine($"the average is {average}");
        }
    }
}
