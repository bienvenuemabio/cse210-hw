using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Hello Prep4 World!");
        
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of number, type 0 when finished");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse (userResponse);

            if (userNumber!=0)
            {
                numbers.Add(userNumber);
            } 
        
        }
        int sum=0;
        foreach(int number in numbers)
        {
             sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average= sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
          if  (number > max)
          {
            max = number;
            Console.WriteLine($"The largest number is: {max}");
          }
          
        }
    }
}