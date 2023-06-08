public class MathAssignment: Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment( string studentName, string topic, string textBookSection, string problems): base(studentName, topic)
    {
        _textBookSection= textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"section{_textBookSection}, problems {_problems}";
    }
}