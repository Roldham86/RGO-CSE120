using System;
using System.Collections.Generic;
using System.Linq;
public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var visibleWords = words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count == 0)
                break;

            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{reference}\n{string.Join(" ", words)}";
    }
}