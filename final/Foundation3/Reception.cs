public class Reception: Event
{
    private string _register;

    public Reception(string register, string title, string description, string date, string time, Address address): base(title,description,date,time,address)
    {
        _register= register;

    }

    public string GetRegister()
    {
        return _register;
    }
}