public class MathAssignment{
    private string _textBookSection;
    private string _problems;

    public string MathAssignment( string studentName, string topic, string textBookSection, string problems): base(studentName, topic){
        _textBookSection= textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList(string _textBookSection, string problem){
        return $"section{_textBookSection}, problems {_problems}";
    }
}