public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        Console.WriteLine("");
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

    }
    public void DisplayEndMessage(){

    }

    public void PausingShowingSpinner(){

    }

    public void PausingShowingCountdownTimer(){
        
    }
}