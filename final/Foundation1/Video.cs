public class Video
{
    private string _title, _author, _lenght;
    private List<Comment> _comments;

    public Video(string title, string author, string lenght) 
    {   
        _title = title;
        _author = author;
        _lenght = lenght;
        _comments = new List<Comment>();
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetLenght(string lenght)
    {
        _lenght = lenght;
    }
    public string GetLenght()
    {
        return _lenght;
    }
    public int GetCommentsNumber()
    {
        int amount = _comments.Count;
        return amount;
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }
    public void GetComments()
    {
        foreach(Comment tracked in _comments){
            tracked.GetCommentInfo();
        }
    }
}


