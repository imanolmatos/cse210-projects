public class Reference {

    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int start, int end)
    { 
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end; 
    
    }

    public Reference(string book, int chapter, int start)
    { 
        _book = book;
        _chapter = chapter;
   
    
    }


    public string GetCompleteReference()
    {

        string CompleteReference = ($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        return CompleteReference;

    }

      public string GetReference()
      {

        string CompleteReference = ($"{_book}:{_chapter}-{_verseStart}");
        return CompleteReference;

    }


    




}

// // This will start by displaying "AAA" and waiting for the user to press the enter key
// Console.WriteLine("AAA");
// Console.ReadLine();

// // This will clear the console
// Console.Clear();

// // This will show "BBB" in the console where "AAA" used to be
// Console.WriteLine("BBB");