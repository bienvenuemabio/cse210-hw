using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> _activities = new List<Activity>();

        Running activity1= new Running("juntion",30,"Running", "03 Nov 2022",25);
        _activities.Add(activity1);

        Cycling activity2= new Cycling(90,"Cycling","12 Jun 2013",40);
        _activities.Add(activity2);

        Swimming activity3 = new Swimming(60,"Swimming","25 Feb 2023",60);
        _activities.Add(activity3);

        foreach(Activity activity in _activities)
        {
            string summary = activity.Summary();
            int _distance= activity.GetDistance();
            int _speed = activity.GetSpeed();
            int _pace = activity.GetPace();
            Console.WriteLine(summary);
        }
    }
}