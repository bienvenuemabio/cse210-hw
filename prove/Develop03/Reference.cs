using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;
    

    public Reference(string book, int chapter, int verse )
    {
        _book= book;
        _chapter= chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse= endverse;
    }

    public string GetReferenceString()
    {
        string text = $"{_book} {_chapter} : {_verse}- {_endverse}";
        return text;

    }

    public void SetReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter= chapter;
        _verse= verse;


    }



}