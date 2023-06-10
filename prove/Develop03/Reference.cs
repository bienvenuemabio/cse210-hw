using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    

    public Reference()
    {
        _book= "";
        _chapter= 1;
        _verse = 1;

    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetReferenceString()
    {
        string text = $"{_book} {_chapter} : {_verse}";
        return text;

    }

    public void SetReference(string book, int chapter, int verse){
        _book = book;
        _chapter= chapter;
        _verse= verse;


    }



}