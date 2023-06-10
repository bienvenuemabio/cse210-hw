using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference r= new Reference("matthew",7,7);
        Console.WriteLine(r.GetReferenceString());


        Console.WriteLine("Please type enter or quit :");
        string userInput= Console.ReadLine();
    

        if (userInput=="enter")
        {
            Console.Clear();
        }
        else
            {
                
            }
        
        
    
    
    }
}