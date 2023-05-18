using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        int guessInput= -1;
        Random randomGeneretor= new Random();
        int number= randomGeneretor.Next(1,101);
        while(guessInput != number)
        {
            Console.WriteLine("What is the  magic number? ");
            Console.WriteLine("What is your guess? ");
            
            guessInput = int.Parse(Console.ReadLine());
            
            if (guessInput < number)
            {
                Console.WriteLine("Higher");
            }
            else if(guessInput > number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guess it");
            }
          
        }
    }
}