using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = " ";
        string sign = "";
        Console.Write("Enter your grade percentage(%): ");
        string grade = Console.ReadLine();
        float convertedGrade = float.Parse(grade);

        if (convertedGrade >= 90)
        {
            letter = "A";
        }
        else if (convertedGrade >= 80)
        {
            letter = "B";
        }
        else if (convertedGrade >= 70)
        {
            letter = "C";
        }
        else if (convertedGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        float signDeterminer = convertedGrade % 10;
        if (signDeterminer >= 7)
        {
            sign = "+";
        }
        else if (signDeterminer < 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Grade letter: {letter}{sign}.");
        if (convertedGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.Write("Sorry! You have to retake the course.");
        }
    }
}