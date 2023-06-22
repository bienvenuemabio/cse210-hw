using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool finished = false;
        do
        {
            Console.WriteLine("You have 0 point");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create new goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Event");
            Console.WriteLine("6.Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int userInput= int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                finished= false;
                Console.WriteLine("The type of Goals are: ");
                Console.WriteLine("1.Simple Goal ");
                Console.WriteLine("2.Eternal Goal ");
                Console.WriteLine("3.Checklist Goal ");
                Console.WriteLine("Which type of goal would you like to create? ");
                int response = int.Parse(Console.ReadLine());
                if (response== 1){
                    

                }else if (response == 2)
                {

                }else if (response== 3)
                {

                }
                
            }
            else
            {
                finished = true;
            }

        } while(finished);
        

    }
}