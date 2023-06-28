public class Assignment
{
    private string _studentName, _topic;

    public Assignment(string studentName = "", string topic = "")
    {
        _studentName = studentName;
        _topic = topic;
    }
    public void SetStudentName(string newName)
    {
        _studentName = newName;
    }
    public void SetTopic(string newTopic)
    {
        _topic = newTopic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"\n{_studentName} - {_topic}");
    }
}