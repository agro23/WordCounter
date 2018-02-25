using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using WordCounter.Models;
using System.Collections.Generic;
using System;
using System.Text;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {



    // [TestMethod]
    // public void UserInputsAWord_AWordEmptyString_Equals_False()
    // {
    //   Console.WriteLine("Please give me a word: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString=="")); // should pass
    // }
    //
    // [TestMethod]
    // public void UserInputsASentence_ASentenceEmptyString_Equals_False()
    // {
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString=="")); // should pass
    // }
    //
    // [TestMethod]
    // public void ProgramRemovesPunctuationFromInputSentence_ASentenceContainsAPeriod_Equals_False()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString.Contains("."))); // should fail
    // }
    //
    // [TestMethod]
    // public void ProgramChecksPunctuationInInputSentence_ASentenceContainsNoPunctuation_Equals_true()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   string[] punct = {".", ",", "!", "?", ";", ":", "-", "'", "\""};
    //   int i = 0;
    //   bool retval = false;
    //   while (i < punct.Length)
    //   {
    //     if (aString.Contains(punct[i]))
    //     {
    //         retval = true;
    //         break;
    //     }
    //     i++;
    //   }
    //   Assert.AreEqual(false, retval);
    // }
    //
    // [TestMethod]
    // public void ProgramRemovesPunctuation_ASentenceContainsNoPunctuation_Equals_true()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length-1; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //
    //   Console.WriteLine("New string is: " + newString.ToString());
    //   bool retval = false;
    //   int k = 0;
    //   string[] punct = {".", ",", "!", "?", ";", ":", "-", "'", "\""};
    //   while (k < punct.Length)
    //   {
    //     if (newString.ToString().Contains(punct[k]))
    //     {
    //         retval = true;
    //         break;
    //     }
    //     k++;
    //   }
    //   Assert.AreEqual(false, (retval==true));
    // }
    //
    // [TestMethod]
    // public void ProgramSplitsAtSpace_ASentenceIsAnArrayNow_Equals_true()
    // {
    //   // * Split the new word string at " " into an array of strings called "sentence" and output it to the Console. This is the array we will compare the key word to in order to count its occurrences. If the array is not empty and its words contain no spaces it will pass the test.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length-1; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //   string [] words = newString.ToString().Split(' ');
    //   for (var i=0; i < words.Length; i++)
    //   {
    //     Console.WriteLine(words[i]);
    //   }
    //   Assert.AreEqual(false, (words.Length <= 0 == true));
    // }
    //
    // [TestMethod]
    // public void ProgramComparesWords_NoMatchesCounterIs0_Equals_true()
    // {
    //   // * Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
    //   //   TESTING: The counter is 0 when a string with no matches to the keyword is entered. Output the counter.:
    //   Console.WriteLine("Please give me a keyword: ");
    //   string keyword = Console.ReadLine().ToUpper();
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine().ToUpper();
    //   StringBuilder newString = new StringBuilder();
    //   for (var i = 0; i < aString.Length; i++)
    //   {
    //     if(! char.IsPunctuation(aString[i])){
    //       newString.Append(aString[i]);
    //     }
    //   }
    //   string [] words = newString.ToString().Split(' ');
    //   int repeatCount = 0;
    //   for (var i=0; i < words.Length; i++)
    //   {
    //     if (words[i].Equals(keyword))
    //     {
    //         repeatCount++;
    //     }
    //   }
    //   Console.WriteLine(keyword + " occurred  " + repeatCount + " time(s)");
    //   Assert.AreEqual(false, (repeatCount <= 0 == true));
    // }

    [TestMethod] // Test the object comes into existance
    public void RepeatCounter_ObjectCreated_IsNotNull_Equals_True()
    {
        RepeatCounter Count = new RepeatCounter("Apples", "I hear apples are pretty nice.");
        Assert.IsNotNull(Count); // should pass
    }

    [TestMethod] // Test the objects Keyword Getter
    public void RepeatCounter_KeywordGetterMatchesParameter_Equals_True()
    {
        string x = "Test";
        RepeatCounter Count = new RepeatCounter(x, "A Test Sentence.");
        string x1 = Count.GetKeyword();
        Assert.AreEqual(x, x1); // should pass
    }

    [TestMethod] // // Test the objects Keyword Setter
    public void RepeatCounter_KeywordSetterAndObjectParamenter_NotEqual_True()
    {
        string x = "Test";
        RepeatCounter Count = new RepeatCounter(x, "A Test Sentence.");
        Count.SetKeyword("Banana");
        string x1 = Count.GetKeyword();
        Assert.AreNotEqual(x, x1); // should pass
    }

    [TestMethod] // Test the objects Sentence Getter
    public void RepeatCounter_SentenceGetterMatchesParameter_Equals_True()
    {
        string x = "A Test Sentence.";
        RepeatCounter Count = new RepeatCounter("Test", x);
        string x1 = Count.GetSentence();
        Assert.AreEqual(x, x1); // should pass
    }

    [TestMethod] // // Test the objects Sentence Setter
    public void RepeatCounter_SentenceSetterAndObjectParamenter_NotEqual_True()
    {
        string x = "A Test Sentence.";
        RepeatCounter Count = new RepeatCounter("Test", x);
        Count.SetSentence("A Different Sentence.");
        string x1 = Count.GetSentence();
        Assert.AreNotEqual(x, x1); // should pass
    }

    [TestMethod] // Remove the punctuation and check for it
    public void StripPunctuationFromSentence_RemovesPunctuation_Equals_True()
    {
        string x = "This: I say, this, is (for SURE) a test Sentence.";
        string x1 = "This I say this is for SURE a test Sentence";
        string newSentence = RepeatCounter.StripPunctuationFromSentence(x);
        Assert.AreEqual(x1, newSentence); // should pass
    }

    [TestMethod]  // Count the occurrences of a word. Is it more than 0?
    public void ObjectCountsKeyword_RepeatsCounted_Equals_True()
    {
    int x = RepeatCounter.Counter("Apples", "Apples to apples: ApPlEs, appLES, APPLES; Also apples.");
    Assert.AreEqual(true, (x > 0 == true));
    }

    [TestMethod]  // Count the occurrences of a word. If more than 0 then multiple punctuation marks were turned to spaces.
    public void ObjectCountsKeyword_EliminatesMuliplePunctuationMarks_Equals_True()
    {
    int x = RepeatCounter.Counter("Test", "This is a test--actually a space test--to see if it drops multiples.");
    Assert.AreEqual(true, (x > 0 == true));
    }

    [TestMethod]  // Count the occurrences of a word. is it more than 0?
    public void ObjectCountsKeyword_RepeatsCountedCorrectAmount_Equals_True()
    {
    int x = RepeatCounter.Counter("Apples", "Apples to apples: ApPlEs, appLES, APPLES; Also apples.");
    Assert.AreEqual(true, ((x == 6)  == true));
    }

  }
}
