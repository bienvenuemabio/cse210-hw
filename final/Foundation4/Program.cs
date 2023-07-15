using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running running1= new Running("juntion",30,"Running", "03 Nov 2022",25);
        Console.WriteLine(running1.Summary());
    }
}