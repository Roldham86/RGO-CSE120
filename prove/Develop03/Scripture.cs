using System;
using System.Collections.Generic;
using System.Linq;
// made by W00f
public class Scripture
{
// Intials
    private Reference reference;
    private List<Word> words;
    private Random random;

// Initilize Scripture class
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
    // Split the text into words and create a list of Word objects
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();
    }

// Hide random words in the scripture
    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
        // Get a list of words that are not hidden
            var visibleWords = words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count == 0)
                break;
        // Select a random index from the list of visible words and hide them
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

// Check if all words in scripture are hidden
    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
    public override string ToString()
    {
        return $"{reference}\n{string.Join(" ", words)}";
    }
}