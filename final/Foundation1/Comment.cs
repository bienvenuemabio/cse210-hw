public class Comment
{
    public string _personName;
    public string _text;
    
    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;

    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_personName},{_text}");
    }

}