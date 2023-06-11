public class BreathingActivity: Activity
{
    private string _msgPromt;

    public BreathingActivity(string msgPromt, string name, string description, int duration): base(name,description,duration)
    {
        _msgPromt= msgPromt;
    }

} 
