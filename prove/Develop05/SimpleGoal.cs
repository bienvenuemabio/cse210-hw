public class SimpleGoal: Goals
{
    private int _PointWanted;
    

    public SimpleGoal(string GoalName, string GoalDescription, int GoalPoint, int PointWanted): base(GoalName,GoalDescription,GoalPoint)
    {
        _PointWanted = PointWanted;
    }

    public override int GetPoint()
    {
        return _PointWanted;

    }
}