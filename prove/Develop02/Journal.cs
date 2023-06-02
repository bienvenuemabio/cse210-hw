
public class Journal{
    public string _journalTitle;
    public string _journalWord;

    public Journal()
    {

    }
    public void Display()
    {
        Console.WriteLine($"{_journalTitle} : {_journalWord}");
    }
} 
