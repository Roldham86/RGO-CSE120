using System;
using System.Collections.Generic;
using System.Linq;
// made by W00f
public class Reference
{
// initals
// The book of the reference
    public string Book { get; }
// The starting chapter of the reference
    public int StartChapter { get; }
// The starting verse of the reference
    public int StartVerse { get; }

// Construct a reference for verse
    public Reference(string book, int startChapter, int startVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
    }

// return a string representation of the reference
    public override string ToString()
    {
        return $"{Book} {StartChapter}:{StartVerse}";
    }
}