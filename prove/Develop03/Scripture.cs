using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();
    public Scripture(Reference reference, string passage)
    {
       _reference = reference;
       string[] parts = passage.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _word.Add(word);
        }
    }

    public void Display()
    {
        Console.WriteLine("\nWelcome to the scripture mastery programme!\n");
        _reference.Display();
        foreach(Word word in _word)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
        
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, _word.Count);
        for ( int i=0; i<3; i++)
        {
            _word[num].Hide();
            num = rnd.Next(0, _word.Count);
        }
    }
}