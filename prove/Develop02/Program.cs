using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
         Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to our journal program!");
        Console.WriteLine("Please select one of the following choices"); 
        string userInput= Console.ReadLine();
        int _choice= int.Parse(userInput);
        while (_choice != 0){
          Console.WriteLine("Please select one of the following choices");
          
          Console.WriteLine("1.Write");  
          Console.WriteLine("2.Display");
          Console.WriteLine("3.load");
          Console.WriteLine("4.Save");
          Console.WriteLine("5.quit");
          Console.WriteLine("What could you like to do");
          int _Choice=int.Parse(Console.ReadLine());
        }
    
    }
}