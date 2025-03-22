using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                    .Select(word => new Word(word))
                    .ToList();
    }

   public void HideRandomWords(int numberToHide)
{
    Random rand = new Random();
    int hiddenCount = 0;

    var nonHiddenWords = _words.Where(word => !word.IsHidden()).ToList();

    while (hiddenCount < numberToHide && nonHiddenWords.Count > 0)
    {
        int index = rand.Next(nonHiddenWords.Count);
        Word word = nonHiddenWords[index];

        word.Hide();
        hiddenCount++;

        nonHiddenWords = _words.Where(word => !word.IsHidden()).ToList();
    }
}


    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        
        return _words.All(word => word.IsHidden());
    }
}
