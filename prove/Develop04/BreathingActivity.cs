public class BreathingActivity: Activity
{
    private string _msgPromt;

    public BreathingActivity(string msgPromt, string name, string description, int duration): base(name,description,duration)
    {
        _name="Listing Activity";
        _description ="This actvty will help you relax by walking your breathing n and out slowly. Clear your mind and focus on your breathing";
        _msgPromt= "how long (in second) would you like for your session?";
        _duration= 0;
    }

} 
