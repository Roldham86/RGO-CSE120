using System;
using System.Collections.Generic;
using System.Linq;
public class Reference
{
    public string Book { get; }
    public int StartChapter { get; }
    public int StartVerse { get; }
    public int EndChapter { get; }
    public int EndVerse { get; }

    public Reference(string book, int startChapter, int startVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = startChapter;
        EndVerse = startVerse;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = endChapter;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (StartChapter == EndChapter && StartVerse == EndVerse)
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
        return $"{Book} {StartChapter}:{StartVerse}-{EndChapter}:{EndVerse}";
    }
}