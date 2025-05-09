using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Core Requirements: Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine pass/fail and print message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard and you'll get it next time!");
        }

        // Stretch Challenge: Determine the sign (+/-)
        int lastDigit = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            sign = "-"; // A- is 90–92
        }
        // No sign for F

        // Final output
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}