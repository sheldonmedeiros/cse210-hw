class Scripture
{
    private string reference;
    private string text;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        words = new List<Word>();
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new Word(word));
        }
    }

    public string GetFullScripture()
    {
        return reference + ": " + GetVisibleText();
    }

    private string GetVisibleText()
    {
        string visibleText = "";
        foreach (Word word in words)
        {
            visibleText += (word.IsHidden) ? "**** " : word.Text + " ";
        }
        return visibleText;
    }

    public bool IsAllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in words)
        {
            if (!word.IsHidden)
                visibleWords.Add(word);
        }

        if (visibleWords.Count > 0)
        {
            int index = random.Next(0, visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
}
