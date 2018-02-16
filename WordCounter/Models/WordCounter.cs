using System.Collections.Generic;
using System;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    private string _keyword;
    private string _sentence;

    public RepeatCounter(string keyword, string sentence)
    {
    _keyword = keyword;
    _sentence = sentence;
    }

    public string GetKeyword()
    {
      return _keyword;
    }
    public void SetKeyword(string keyword)
    {
      _keyword = keyword;
    }

    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    // public string ValidateSentence(string sentence)
    // {
    //   // strip the sentence string of punctuation and copy it into new string
    //   // turn it all to upper case
    //   // sentence = newSentence;
    //   return sentence;
    // }
    //
    // public static int Counter(string keyword, string sentence)
    // {
    //   // ValidateSentence(sentence);
    //   // split the new string at " "
    //   // go through the resulting string array and count the keyword matches
    //   // return the number of matches
    //   int times = 1;
    //   return times;
    // }

  }
}
