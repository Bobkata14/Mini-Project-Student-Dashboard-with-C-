using System;

namespace StudentDahsboard
{
    class Dashboard
    {
        static void Main(string[] args)
        {

            //Student Dashboard

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a group letter: ");
            char groupLatter = Convert.ToChar(Console.ReadLine());

            bool isFullTime = true;

            double grade1 = 4;
            double grade2 = 5;
            double grade3 = 6;
            double averageGrade = (grade1 + grade2 + grade3) / 3;
            bool hasPassed = averageGrade >= 3.00;
            bool eligibleForScholarship = averageGrade >= 5.50 && isFullTime;

            decimal monthBudget = 660;
            decimal regularExpenses = 250;
            decimal extraExpenses = 80;

            decimal totalExpenses = regularExpenses;
            totalExpenses += extraExpenses;
            decimal remainingBudget = monthBudget - totalExpenses;

            int ageInMonth = age * 12;
            int ageNextYear = age;
            ageNextYear++;

            Console.WriteLine(" ");

            Console.WriteLine("===========================");
            Console.WriteLine("Student Dashboard".ToUpper());
            Console.WriteLine("===========================");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {groupLatter}");
            Console.WriteLine($"Full Time Student: {isFullTime}");

            Console.WriteLine(" ");

            Console.WriteLine("--- Academic Report ---".ToUpper());
            Console.WriteLine($"Grade 1: {grade1}");
            Console.WriteLine($"Grade 2: {grade2}");
            Console.WriteLine($"Grade 3: {grade3}");
            Console.WriteLine($"Average grade: {averageGrade}");
            Console.WriteLine($"Passed: {hasPassed}");
            Console.WriteLine($"Eligible for scholarship: {eligibleForScholarship}");

            Console.WriteLine(" ");

            Console.WriteLine("--- monthly budget ---".ToUpper());
            Console.WriteLine($"Monthly budget: {monthBudget}");
            Console.WriteLine($"Total expnses: {totalExpenses}");
            Console.WriteLine($"Remaning budget: {remainingBudget}");

            Console.WriteLine(" ");

            Console.WriteLine("--- additional info ---".ToUpper());
            Console.WriteLine($"Age in month {ageInMonth}");
            Console.WriteLine($"Age in next year: {ageNextYear}");

            Console.WriteLine("=======================================================");
            
        }
    }
}