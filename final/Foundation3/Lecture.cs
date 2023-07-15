public class Lecture: Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speakerName, int capacity, string type, string title, string description, string date, string time, Address address  ): base( type, title,description,date, time,address)                                                                                                                                                                                                  
    {
        _speakerName = speakerName;
        _capacity= capacity;

    }

    public string  GetSpeaker()
    {
        return _speakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public string GetLecture()
    {
        return $"Speaker Name: {_speakerName} \n Capacity: {_capacity}";
    }

}