public class Reference 
{
    private string _book;
    private int _chapter, _fstVerse, _endVerse;

    public Reference(string book, int chapter, int fstVerse)
    {
        _book       = book;
        _chapter    = chapter;
        _fstVerse   = fstVerse;
        _endVerse   = 0;
    }
    public Reference(string book, int chapter, int fstVerse, int endVerse)
    {
        _book       = book;
        _chapter    = chapter;
        _fstVerse   = fstVerse;
        _endVerse   = endVerse;
    }

    public string GetDisplayReference()
    {
        string referenceText;

        if (_endVerse == 0)
        {
            referenceText = $"{_book} {_chapter}:{_fstVerse}";
        }
        else
        {
            referenceText = $"{_book} {_chapter}:{_fstVerse}-{_endVerse}";
        }

        return referenceText;
    }

}