public class WritingAssignment{
    private string _title;

    public class WritingAssignment( string studentName, string topic, string title): Base(studentName, topic)
    {
        _title= title;

    }

    public string GetWritingInformation()
    {
        string studentName= GetStudentName();
        return $"{_title} by {_studentName};
    }
} 