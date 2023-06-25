class Word
{
    private string _text;
    private bool   _isHidden;

    public Word(string text, bool isHidden = false)
    {
        _text = text;
        _isHidden = isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = true;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }

}