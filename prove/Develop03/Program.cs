using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference r= new Reference("matthew",7,7,8);
        Console.WriteLine(r.GetReferenceString());
        Scripture s= new Scripture("Ask and it will be given to you; seek and you will find; knock and it will be opened to you. Whosoever ask shall receive, whosoever seek shall found and whosoever knock shall be opened ");
        Console.WriteLine(s.displayScripture());

        List<Scripture>_scripture= new List<Scripture>();


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