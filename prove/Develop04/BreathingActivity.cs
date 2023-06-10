public class BreathingActivity: Activity
{
    private string _msgPromt;

    public BreathingActivity(string _msgPromt, string _name, string _description, int _duration): base(name,description,duration)
    {
        _msgPromt= msgPromt;
    }

} 
