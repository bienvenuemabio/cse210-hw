using System;

class Program
{
    static void Main(string[] args)
    {
      bool quit = false;
      do
      {
        Console.Write("Welcome to our journal program!");
        Console.WriteLine("1.Write");  
        Console.WriteLine("2.Display");
        Console.WriteLine("3.load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.quit");


      Console.Write("What could you like to do?: "); 
      //string userInput= Console.ReadLine();
      int _userOption= int.Parse(Console.ReadLine());
      if (_userOption == 5)
      {
        quit= true;
      }else
      {
        quit= false;
      }
        
       switch(_userOption)
       {
        case 1:
          DateTime theCurrentTime = DateTime.Now;
          string _dateText = theCurrentTime.ToShortDateString();
          Console.WriteLine($"date:{_dateText}");

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

            break;
        
          case 2:

            break;

          case 3:

            break;
          case 4:

            break;
       }
      
    Console.Clear();
      
          
      
    
    }while(quit);

      }

      
}