using System.Collections.Generic;
using System;

namespace Leetspeak.Models
{
  public class LeetspeakTranslator
  {
    private string _inputWord;
    private static List<string>

    public LeetspeakTranslator(string inputWord)
    {
      _inputWord = inputWord;
    }

    public string GetInputWord()
    {
      return _inputWord;
    }

    public string ChangeLetter()
    {
      return _inputWord;
    }
  }
}
