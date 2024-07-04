
using System;

namespace Average
{
    public class Student
    {
        public double Chemistry;
        public double Maths;
        public double ComputerScience;
        public double Physics;

        public double CalculateAverage()
        {
            double average = (Chemistry + Maths + ComputerScience + Physics) / 4.0;
            return average;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            string grade = "";

            try
            {
                Console.WriteLine("Enter the chemistry marks:");
                student1.Chemistry = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the maths marks:");
                student1.Maths = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the computer science marks:");
                student1.ComputerScience = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the physics marks:");
                student1.Physics = Convert.ToDouble(Console.ReadLine());

                double average = student1.CalculateAverage();
                Console.WriteLine("The average of the four Subjects: " + average);

                // The grade calculation logic
                if (average >= 80)
                {
                    grade = "A";
                }
                else if (average >= 70 && average < 80)
                {
                    grade = "B";
                }
                else if (average >= 60 && average < 70)
                {
                    grade = "C";
                }
                else if (average >= 50 && average < 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }

                Console.WriteLine("Grade: " + grade);

                // Switch statement to print remarks based on the grade
                switch (grade)
                {
                    case "A":
                        Console.WriteLine("Excellent! Your grade is A");
                        break;
                    case "B":
                        Console.WriteLine("Good! Your grade is B");
                        break;
                    case "C":
                        Console.WriteLine("Satisfactory. Your grade is C");
                        break;
                    case "D":
                        Console.WriteLine("Pass. Your grade is D");
                        break;
                    case "F":
                        Console.WriteLine("Fail. Your grade is F");
                        break;
                    default:
                        Console.WriteLine("Invalid grade");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered. Please enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}


