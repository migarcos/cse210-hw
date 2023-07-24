public class Reception: Event
{
    private string _mailReg;
    public Reception()
    {
    }
    public Reception(string title, string descr, string date, string time, string mail): base(title, descr, date, time)
    {
        _mailReg = mail;
    }
    public void SetMail(string mail)
    {
        _mailReg = mail;
    }
    public string GetMail()
    {
        return _mailReg;
    }
    public string FullDetails()
    {
        string Details = $"{StdDetails()},\nRegister: {_mailReg}";
        return Details;;
    }
    public string ShortDetails()
    {
        string StdDetails = $"Reception: {GetTitle()}, {GetDate()}";
        return StdDetails;
    }
}