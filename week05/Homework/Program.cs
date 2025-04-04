using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Doe", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");

        MathAssignment a2 = new MathAssignment("Walter Evans", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment a3 = new WritingAssignment("Martha Stewart", "European History", "The cause of WWII");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine("");
    }

}