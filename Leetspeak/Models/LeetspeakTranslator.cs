using System.Collections.Generic;
using System;

namespace Leetspeak.Models
{
  public class LeetspeakTranslator
  {
    private string _inputWord;
    private static List<string> _letters = new List<string> {};
    private static List<string> _converted = new List<string> {};

    public LeetspeakTranslator(string inputWord)
    {
      _inputWord = inputWord;
      _letters.Add(_inputWord);
    }

    public string GetInputWord()
    {
      return _inputWord;
    }


    public List<string> ChangeLetter()
    {
      char[] leetArray = _letters[0].ToCharArray();
      for(int i = 0; i < leetArray.Length; i++)
      {
        if (leetArray[i] == 'e' || leetArray[i] == 'E')
        {
          leetArray[i] = '3';
        } else if (leetArray[i] == 'o' || leetArray[i] == 'O')
        {
          leetArray[i] = '0';
        } else if (leetArray[i] == 'I')
        {
          leetArray[i] = '1';
        } else if (leetArray[i] == 't' || leetArray[i] == 'T')
        {
          leetArray[i] = '7';
        } else if (leetArray[i] == 'S' || leetArray[i] == 's')
        {
          leetArray[i] = 'z';
        }
      }
      string result = string.Join("", leetArray);
      _converted.Add(result);
      return _converted;
    }

    public static void ClearAll()
    {
      _letters.Clear();
      _converted.Clear();
    }
  }
}
