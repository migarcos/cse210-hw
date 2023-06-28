public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title}");
    }
}