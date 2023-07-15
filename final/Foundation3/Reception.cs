public class Reception: Event
{
    private string _registerEmail;

    public Reception(string registerEmail, string type, string title, string description, string date, string time, Address address): base(type,title,description,date,time,address)
    {
        _registerEmail= registerEmail;

    }

    public string GetRegisterEmail()
    {
        return $"Email: {_registerEmail}";
    }
}