public class CheckListGoal : Goals
{
    private int _GainNumber;
    private int _bonus;
    private int _CheckTimes;

    public CheckListGoal():base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        _CheckTimes= int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it many times?");
        _bonus= int.Parse(Console.ReadLine());


    }
    public override int GetPoint()
    {
        return _GainNumber;

    }


}