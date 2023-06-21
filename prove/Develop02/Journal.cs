
public class Journal{
    public string _name;
    public List <Entry> _entries = new List <Entry>();

public Journal()
{
}
public void AddingAnEntry()
{
    foreach (Entry entry in _entries)
    {
        entry.DisplayData();

    }

}
public void DisplayingAllEntries()
{

}
public void SavingToFile()
{

}
public void LoadingFromFile()
{
    
}
} 
