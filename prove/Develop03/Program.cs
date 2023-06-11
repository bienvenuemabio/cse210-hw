using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference r= new Reference("matthew",7,7);
        Console.WriteLine(r.GetReferenceString());
        Scripture s= new Scripture("Ask and it will be given to you; seek and you will find; knock and it will be opened to you");
        Console.WriteLine(s.displayScripture());


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