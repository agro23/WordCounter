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
        string x = "This: I say, this, is (for SURE) a...test Sentence.";
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
    int x = RepeatCounter.Counter("Test", "This is a test--actually a space test--to see... if it drops multiples.");
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
