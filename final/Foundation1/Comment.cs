public class Comment
{
    private string _personName, _comment;
    public Comment(string Name, string comment)
    {
        _personName = Name;
        _comment = comment;
    }
    public void GetCommentInfo(){
        Console.WriteLine($"\t{_personName}: \"{_comment}\"");
    }
}