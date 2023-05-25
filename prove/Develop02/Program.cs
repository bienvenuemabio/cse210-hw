using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Hello Develop02 World!");
      Console.Write("Welcome to our journal program!");
      Console.Write("1.Write");  
      Console.Write("2.Display");
      Console.Write("3.load");
      Console.Write("4.Save");
      Console.Write("5.quit");
      Console.WriteLine("What could you like to do?: "); 
      string userInput= Console.ReadLine();
      int _userOption= int.Parse(userInput);
        
      while (_userOption != 5)  
      {
        if (_userOption ==1)
        {
          DateTime theCurrentTime = DateTime.Now;
          string _dateText = theCurrentTime.ToShortDateString();
          Console.WriteLine($"{_dateText}: ");

          List <string> prompts = new List<string>();
          prompts.Add("Who was the most interesting person I interacted with today?");
          prompts.Add("What was the best part of my day?");
          prompts.Add("How did I see the hand of the Lord in my life today?");
          prompts.Add("What was the strongest emotion I felt today?");
          prompts.Add("If I had one thing I could do over today, what would it be?");
          prompts.Add("How was the day, good or not?");

          foreach (string p in prompts)
          {
            Console.WriteLine(p);
          }



        }
      }
          
      
    
    }
}