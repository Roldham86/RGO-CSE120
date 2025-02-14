using System;
using System.Collections.Generic;
using System.Linq;
// made by W00f
public class Word
{
// text of word, check if hidden
    private string text;
    public bool IsHidden { get; private set; }
//initialize the Word object
    public Word(string text)
    {
        this.text = text;
        IsHidden = false;
    }
// hide the word
    public void Hide()
    {
        IsHidden = true;
    }
//return the word's text or underscores if hidden
    public override string ToString()
    {
        return IsHidden ? new string('_', text.Length) : text;
    }
}