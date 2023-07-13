public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public int _commentNumber;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author= author;
        _length = length;
       _comments= new List<Comment>();

    }
    public void StoreComment(Comment comments)
    {
          _comments.Add(comments);

    }
    public void CommentNumber(int CommentNumber)
    {
        foreach(Comment comment in _comments)
        {
            _commentNumber= _comments.Count();
        }
        Console.WriteLine($"There are {_commentNumber} comments made for this video");
        
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video title:{_title}");
        Console.WriteLine($"Author:{_author.ToUpper()}");
        Console.WriteLine($"Length:{_length} seconds");
        Console.WriteLine("The comments of this video are:");  

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
            _commentNumber =_comments.Count();
        }

        Console.WriteLine($"There are {_commentNumber} comments made");

    }
}
