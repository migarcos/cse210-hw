public class MathAssignment: Assignment
{
    private string _textbookSection, _problems;

    public MathAssignment(string studentName, string topic, string textbookSection = "", string problems = "") : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public void SetTextbookSection(string newSection)
    {
        _textbookSection = newSection;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void GetHomeWorkList()
    {
        Console.WriteLine($"{_textbookSection} {_problems}");
    }

}