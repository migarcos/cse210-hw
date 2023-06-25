class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();

    private List<int> _visibleWords = new List<int>();

    public Scripture(Reference reference, string paragraph)
    {
        _reference = reference;
        List<string> allWords = paragraph.Split(' ').ToList();
        foreach(string word in allWords)
        {
            Word newWord = new Word(word);
            _wordList.Add(newWord); 
            _visibleWords.Add(_wordList.IndexOf(newWord));
        }
    }

    public void HideRandomWords()
    {   
        Random randomValue = new Random();
        int indexToHide, howMany;

        if (_visibleWords.Count() < 6)
        {
            howMany = _visibleWords.Count() + 1;            
        }
        else
        {
            howMany = randomValue.Next(3,6);
        }

        for (int i = 1; i < howMany; i++)
        {
            indexToHide = randomValue.Next(0, _visibleWords.Count()-1);
            int positionInPrhase = _visibleWords[indexToHide];
            _wordList[positionInPrhase].Hide();
            _visibleWords.Remove(positionInPrhase);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _wordList)
        {
            if (word.GetIsHidden() == false) {
                scriptureText += word.GetDisplayText() + " ";
            }
            else{
                scriptureText += new string('_',word.GetDisplayText().Length) + " ";
            }
        }
        return ($"{_reference.GetDisplayReference()} {scriptureText}"); // \n{_visibleWords.Count()}
    }
    public bool AllHidden()
    {   
        bool complete = false;

        if (_visibleWords.Count() == 0)
        {
            complete = true;
        }
        return complete;
    }
}