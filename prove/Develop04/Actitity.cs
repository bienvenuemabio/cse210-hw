public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _startMessage;
    protected string _endMessage;

    public Activity(string name, string description, int duration)
    {
        
        _name = name;
        _description= description;
        _duration= duration;


    }

    public string GetActivityName()
    {
        return _name;
    }

    public string GetActivityDescription()
    {
        return _description;
    }

    public int getActivityduration()
    {
        return _duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine("Get ready");

    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done");

    }

    public void PausingShowingSpinner(){

    }

    public void PausingShowingCountdownTimer(){
        
    }
}