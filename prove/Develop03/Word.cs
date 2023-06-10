public class Word
{
    private string _word;
    private bool _hidden = false;
    public Word(string word)
    {
        _word = word;
    }
    public void DisplayWord()
    {
        if (_hidden)
        {
            foreach (char l in _word)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_word);
        }
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
}
