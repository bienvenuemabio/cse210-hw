public class Goals
{
    private string _GoalName;
    private string _GoalDescription;
    private int _GoalPoint;

    public Goals()
    {
        Console.WriteLine("What is the name of your goal?");
        _GoalName = Console.ReadLine();
        Console.WriteLine("What is a description of your goal?");
        _GoalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of point associated with this goal?");
        _GoalPoint = int.Parse(Console.ReadLine());

    } 
    public string GetName()
    {
        return _GoalName;
    }

    public string GetDescription()
    {
        return _GoalName;
    }

    public void RecordEvent()
    {
        Console.WriteLine($"{_GoalName},{_GoalDescription},{_GoalPoint}");
    }

    public void iscompleted()
    {
        Console.WriteLine($"currentlycompleted");
    }


    public virtual int GetPoint()
    {
        return _GoalPoint;

    }
    

    
}