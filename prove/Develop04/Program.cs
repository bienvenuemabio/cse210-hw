using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit=false;
        do
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1.Start Breathing Activity");  
            Console.WriteLine("2.Start Reflecting Activity");
            Console.WriteLine("3.Start Listing Activity");
            Console.WriteLine("4.Quit");
            Console.Write("Select your choice:");

            int _userChoice= int.Parse(Console.ReadLine());

            if (_userChoice == 4)
            {
                quit = true;
            }
            else
            {
                quit= false;
            }

            switch (_userChoice)
            {
                case 1:

                    break;
                
                case 2:

                    break;
                
                case 3: 

                    break;
            }
        
        

        }while(quit);
        
    }
}