public class Save
{
    private string _filename;

    public Save()
    { 
        Console.WriteLine("What is your file name?: ");
        _filename= Console.ReadLine();
    }

    public string Getfile()
    {
        return _filename;
    }
}