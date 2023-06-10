
using System;
using System.Linq;
using System.Collections.Generic;


public class Scripture
{

    private List<Word> _words = new List<Word>();
    private Random _rnd = new Random();
    private List<int> _usedIndexes = new List<int>();




    public Scripture(string text)
    {

        string[] _array = text.Split(" ");
        foreach (string word in _array)
        {
            Word newword = new Word(word);
            _words.Add(newword);
        }
    }


    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }
    }

    public void HideWords()
    {
        int index;
        do
        {
            index = _rnd.Next(_words.Count);
        }
        while (_usedIndexes.Contains(index));
        _usedIndexes.Add(index);
        _words[index].HideWord();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }

}