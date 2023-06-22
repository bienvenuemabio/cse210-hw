public class CheckListGoal : Goals
{
    private int _GainNumber;
    private int _bonus;
    private int _CheckTimes;

    public CheckListGoal(string GoalName, string GoalDescription, int GoalPoint, int GainNumber, int bonus, int CheckTimes):base(GoalName, GoalDescription,GoalPoint)
    {
        int _GainNumber = GainNumber;
        int _bonus= bonus;
        int _CheckTimes= CheckTimes;

    }
    public override int GetPoint()
    {
        return _GainNumber;

    }


}