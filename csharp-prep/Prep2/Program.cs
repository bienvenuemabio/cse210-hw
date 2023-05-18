using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        String userInput = Console.ReadLine();
        int _gradePercent =int.Parse(userInput);

        string letter ="";
        if (_gradePercent  >= 90)
        {
            letter="A";
        }
        else if (_gradePercent  >= 80)
        {
            letter="B";
        }
        else if (_gradePercent  >= 70)
        {
            letter="C";
        }
        else if (_gradePercent  >= 60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }
         Console.WriteLine($"Your grade is: {letter}");
        
        if (_gradePercent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sorry good luck next time!");
        }
 
    }
}