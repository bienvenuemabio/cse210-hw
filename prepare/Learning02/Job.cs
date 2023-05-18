public class Job
{
    public string _jobTitle="";
    public string _companyName="";
    public int _startYear= 0;
    public int _endYear= 0;

    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
    }

}
