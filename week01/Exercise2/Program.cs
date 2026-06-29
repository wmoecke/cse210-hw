using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage:");
        string input = Console.ReadLine();
        int gradePercentage;

        // Validate input
        if (!int.TryParse(input, out gradePercentage))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine();
        Console.WriteLine($"Your letter grade is: {letter}");

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry! Keep trying and you'll do better next time.");
        }
    }
}