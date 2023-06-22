public abstract class Goals{
    private string _GoalName;
    private string _GoalDescription;
    private int _GoalPoint;

    public Goals(string GoalName, string GoalDescription, int GoalPoint)
    {
        _GoalName= GoalName;
        _GoalDescription= GoalDescription;
        _GoalPoint= GoalPoint;

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


    public abstract int GetPoint();
}