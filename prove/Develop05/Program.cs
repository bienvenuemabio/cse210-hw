using System;

class Program
{
    static void Main(string[] args)
    {

        //int points = 0;

        bool finished = false;
        do
        {
            //Console.WriteLine($"You have {points} points");
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            int userInput= int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                finished= false;
                Console.WriteLine("The type of Goals are: ");
                Console.WriteLine("1.Simple Goal ");
                Console.WriteLine("2.Eternal Goal ");
                Console.WriteLine("3.Checklist Goal ");
                Console.Write("Which type of goal would you like to create? ");
                int response = int.Parse(Console.ReadLine());

                //List<Goals> goal = new List<Goals>();
                //goal.Add(new Goals());
                

                if (response== 1)
                {
                    SimpleGoal simple = new SimpleGoal();
                    DisplayMenu();
                    
                    //goal.Add(new SimpleGoal());
                }
                
                else if (response == 2)
                {
                    EternalGoal eternal = new EternalGoal();
                    DisplayMenu();
                
                    //goal.Add(new EternalGoal());

                }
                else if (response== 3)
                {
                    CheckListGoal check= new CheckListGoal();
                    //goal.Add(new CheckListGoal());
                    DisplayMenu();

                }

                
                
            }
            else if (userInput==2)
            {
                finished = false;
                SimpleGoal simple= new SimpleGoal();
                simple.GetName();
                Console.WriteLine("The goals are: ");
                Console.WriteLine($"[ ] {simple.GetName()}, {simple.GetDescription}");


            }
            else if (userInput == 3)
            {
                finished= false;
                Save s = new Save();
            }
            else if (userInput == 4)
            {
                Load l = new Load();
                finished= false;
            }
            else if (userInput == 5)
            {
                finished= false;

            }
            else
            {
                Console.Write("Thank you for playing the game.");
                finished=true;
            }


        } while(finished);
      static void DisplayMenu()
        {
            int points = 0;
            Console.WriteLine($"You have {points} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create new goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Event");
            Console.WriteLine("6.Quit");


        }  

    }
}