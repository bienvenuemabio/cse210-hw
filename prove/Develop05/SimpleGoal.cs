public class SimpleGoal: Goals
{
    private int _PointWanted;
    

    public SimpleGoal(): base()
    {
        
    }

    public override int GetPoint()
    {
        return _PointWanted;

    }

   // public override string ShowSimpleGoal(string GoalName, string GoalDescription)
   // {
    //    Console.WriteLine("The goals are: ");
    //    Console.WriteLine($"1.[ ] {_GoalName}, ({_GoalDescription})");
    //}
}