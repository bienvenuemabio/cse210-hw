public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<string> _comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author= author;
        _length = length;
        //_comment= new List<string>();

    }
    public void StoreComment()
    {


    }
    public void CommentNumber(int length)
    {
        
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");   
    }
}
