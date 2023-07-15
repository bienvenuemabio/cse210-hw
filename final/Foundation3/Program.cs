using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        //Address address1= new Address("a001","London");
        //Event event1 = new Event("Lecture","Magasine", "It contains everything our company does","10/07/2023","8 am",address1);
        //Console.WriteLine(event1.StandardDetails());

        Address addressL= new Address("al1", "Paris","France");
        Lecture lecture1 = new Lecture("Miss Genevieve",10,"Lecture","Novels","Let people know about the new novel and let them ask question ","04/08/2023","9 am",addressL);
        Console.WriteLine($"{lecture1.GetType()} Event");
        Console.WriteLine("Standard Details");
        Console.WriteLine(lecture1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("fulldetails");
        Console.WriteLine(lecture1.FullDetails() + lecture1.GetLecture());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(lecture1.ShortDescription());
        Console.WriteLine();
        Console.WriteLine();


        Address addressR= new Address("AR01","Salt Lake City","USA");
        Reception reception1 = new Reception("fredi1@gmail.com","Reception","Wedding","Put everything in place for the wedding to be successfull","16/08/2023","9 am",addressR);
        Console.WriteLine($"{reception1.GetType()} Event");
        Console.WriteLine("Standard Details");
        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("fulldetails");
        Console.WriteLine(reception1.FullDetails()+ reception1.GetRegisterEmail());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(reception1.ShortDescription());
        Console.WriteLine();
        Console.WriteLine();

        Address addressO= new Address("AO001","Korogo", "Cote d'Ivoire");
        OutdoorGathering outdoor1= new OutdoorGathering("Cool weather","OutdoorGathering","Sport","football for the employees","20/09/2023","7 am",addressO);
        Console.WriteLine($"{outdoor1.GetType()} Event");
        Console.WriteLine("Standard Details");
        Console.WriteLine(outdoor1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("fulldetails");
        Console.WriteLine(outdoor1.FullDetails() + outdoor1.GetWeather());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(outdoor1.ShortDescription());


        //List <Event> _event= new List<Event>();
        //_event.Add(lecture1);
        //_event.Add(reception1);
        //_event.Add(outdoor1);







    }
}