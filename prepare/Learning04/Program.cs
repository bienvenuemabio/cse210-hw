using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment a1= new Assignment("Samuel Benett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Assignment a2 = new Assignment("Roberto Rodriguez","fraction","7.3","8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        Assignment a3 = new Assignment("Mary Waters","European History", "the causes of world war II by Mary Waters ");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}