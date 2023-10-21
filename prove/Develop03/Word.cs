using System;

public class Word
{
    private string _word;
    private bool _isHidden;
    private string _displayWord;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
        _displayWord = word;
    }

    public void Hide()
    {
        _isHidden = true;
        _displayWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            _displayWord += "_";
        }
    }

    public void Show()
    {
        _isHidden = false;
        _displayWord = _word;
    }

    public void Display()
    {
        Console.Write(_displayWord);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}