public class ReflectingActivity: Activity
{
    private string _messagePromt;

    public ReflectingActivity(string name,string description,int duration, string messagePromt): base(name,description,duration)
    {
        _messagePromt= messagePromt;
    }

    

}