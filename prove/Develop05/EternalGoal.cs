public class EternalGoal:Goals
{
    private int _PointforGoal;

    public EternalGoal(string GoalName, string GoalDescription, int GoalPoint, int PointforGoal): base(GoalName,GoalDescription,GoalPoint)
    {
        _PointforGoal= PointforGoal;
    }

    public override int GetPoint()
    {
        return _PointforGoal;
    }
}