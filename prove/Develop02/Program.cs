using System;

class Program
{
    static void Main(string[] args)
    {
      bool quit = false;
      do
      {
        Console.WriteLine("Welcome to our journal program!");
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
      }
      else
      {
        quit= false;
      }
        
       switch(_userOption)
       {
        case 1:
          Entry entry1= new Entry();
          entry1._data="Who was the most interesting person I interacted with today?";

          Entry entry2= new Entry();
          entry2._data="What was the best part of my day?";

          Entry entry3= new Entry();
          entry3._data="How did I see the hand of the Lord in my life today?";

          Entry entry4= new Entry();
          entry4._data="What was the strongest emotion I felt today?";

          Entry entry5= new Entry();
          entry5._data="If I had one thing I could do over today, what would it be?";

          Entry entry6= new Entry();
          entry6._data="How was the day, good or not?";

          PromptGenerator promtgene = new PromptGenerator();
          

        
      

          
        

            break;
        
          case 2:
          DateTime theCurrentTime = DateTime.Now;
          string _dateText = theCurrentTime.ToShortDateString();
          Console.Write($"date:{_dateText}");

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