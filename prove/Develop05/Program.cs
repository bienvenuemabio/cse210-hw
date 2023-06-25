using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;

        bool finished = false;
        do
        {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create new goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Event");
            Console.WriteLine("6.Quit");
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

                List<Goals> goal = new List<Goals>();
                goal.Add(new Goals());

                if (response== 1)
                {
                    goal.Add(new SimpleGoal());
                }
                
                else if (response == 2)
                {
                    goal.Add(new EternalGoal());

                }
                else if (response== 3)
                {
                    goal.Add(new CheckListGoal());

                }

                foreach (Goals goals in goal)
                {
                    goals.GetName();
                    goals.GetDescription();
                    goals.GetPoint();

                }
                
            }
            else if (userInput==2)
            {
                finished = false;

            }

        } while(finished);
        

    }
}