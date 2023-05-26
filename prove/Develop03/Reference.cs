public class Reference{
    private string _bookTitle;
    private int _chapter;
    private int _verse;

    public string GetReference()
    {
        return _bookTitle + " " + _chapter+ ": "+ _verse;
    }

}