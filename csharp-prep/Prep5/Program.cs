using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber =  PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName,userNumber);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
        Console.WriteLine("Please enter your name?");
        String name = Console.ReadLine();

        return name;
        }

        static int PromptUserNumber()
        {
        Console.WriteLine("Please enter your favorite number?");
        String userInput = Console.ReadLine();
        int number =int.Parse(userInput);
        Console.WriteLine($"your favorite  number is:  {number}");

        return number;

        }

        static int SquareNumber(int number)
        {
            int square= number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            
            Console.WriteLine($"Brother {name}, the square of your number is: {square}");
        }
}