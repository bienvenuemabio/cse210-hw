using System;

class Program
{
    static void Main(string[] args)
    {
      string labelName;
      bool quit = false;
      do
      {
        DisplayMenu();
        int _userOption= int.Parse(Console.ReadLine());
        
      if (_userOption == 5)
      {
        quit= true; 
      }
      else
      {
        quit= false;
      }
        
       switch(_userOption)
       {
        case 1:
        Journal myjournal= new Journal();
        Entry entry = new Entry();
        PromptGenerator promptGeneate=  new PromptGenerator("What was the best part of my day?");
        promptGeneate.DisplayGeneratePrompt();
        //Console.WriteLine("Who was the most interesting person I interacted with today?");
        //string _userResponse= Console.ReadLine();
        
        
           break;
        
          case 2:
          DateTime theCurrentTime = DateTime.Now;
          string _dateText = theCurrentTime.ToShortDateString();
          Console.Write($"date:{_dateText}");
          labelName = DateTime.Now.ToString("MMM dd yyyy");

            break;

          case 3:

            break;
          case 4:

            break;
       }
      
    Console.Clear();
      
          
      
    
    }while(quit);
    static void DisplayMenu()
    {
      Console.WriteLine("Welcome to our journal program!");
      Console.WriteLine("1.Write");  
      Console.WriteLine("2.Display");
      Console.WriteLine("3.load");
      Console.WriteLine("4.Save");
      Console.WriteLine("5.quit");


      Console.Write("What could you like to do?: "); 
      //string userInput= Console.ReadLine();
      

    }

  }

      
}