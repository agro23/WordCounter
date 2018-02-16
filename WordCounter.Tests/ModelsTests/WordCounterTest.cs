using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using WordCounter.Models;
using System.Collections.Generic;
using System;

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

    // [TestMethod]
    // public void ProgramRemovesPunctuationFromInputSentence_ASentenceContainsAPeriod_Equals_False()
    // {
    //   // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
    //   Console.WriteLine("Please give me a string of words: ");
    //   string aString = Console.ReadLine();
    //   Assert.AreEqual(false, (aString.Contains("."))); // should fail
    // }

    [TestMethod]
    public void ProgramChecksPunctuationInInputSentence_ASentenceContainsNoPunctuation_Equals_true()
    {
      // * Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
      Console.WriteLine("Please give me a string of words: ");
      string aString = Console.ReadLine();
      string[] punct = {".", ",", "!", "?", ";", ":", "-", "'", "\""};
      int i = 0;
      bool retval = false;
      while (i < punct.Length)
      {
        if (aString.Contains(punct[i]))
        {
            retval = true;
            break;
        }
        i++;
      }
      Assert.AreEqual(false, retval);
    }

    // * Split the new word string at " " into an array of strings called "sentence" and output it to the Console. This is the array we will compare the key word to in order to count its occurrences. If the array is not empty and its words contain no spaces it will pass the test.
    //   - EXPECTED INPUT: "Apples, I hear, are a tasty fruit."
    //   - EXPECTED OUTPUT:
    //       - Apples
    //       - I
    //       - hear
    //       - are
    //       - a
    //       - tasty
    //       - fruit
    //
    // * Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
    //   TESTING: The counter is 0 when a string with no matches to the keyword is entered. Output the counter.:
    //   - EXPECTED INPUT: "Bananas"
    //   - EXPECTED INPUT: "Apples, I hear, are a tasty fruit."
    //   - EXPECTED OUTPUT: 0.
    //
    // * Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
    //   TESTING: The repeat counter should be > 0 if a sentence of just the keyword repeated 5, or 3 times, or 12 times, etc. is entered. Output the counter.:
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples APPLEs Apples APPLES apples."
    //   - EXPECTED OUTPUT: 5.
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples, APPLES, apples."
    //   - EXPECTED OUTPUT: 3.
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples; APPLEs: Apples APPLES apples Apples, APPLES, apples Apples, APPLES, apples ApPlEs!"
    //   - EXPECTED OUTPUT: 12.
    //
    // * Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
    //   - TESTING: If a string that includes the keyword a few random times where the counter should be equal to the number of keywords I enter to pass.:
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //   - EXPECTED OUTPUT: 3.
    //
    // * Tell the user with a sentence how many times the word has occurred in the sentence.
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples are a tasty fruit."
    //   - EXPECTED OUTPUT: "Apples occurred 1 time(s) in the sentence you provided."
    //
    // * Create a RepeatCounter Object model with a name. Simply test the object comes into existence. IsNotNull(Object) = true.
    //   - NO INPUT OR OUTPUT
    //
    // * Add Getters, and Setters as needed. Test them by getting and setting vars and passing them back and forth.
    //   - NO INPUT OR OUTPUT
    //
    // * Add a Method to accept a key word from the user. If the string is not empty, they have given a keyword.
    //   - PROMPT: "Please enter a keyword."
    //   - EXPECTED SAMPLE INPUT: "Apples"
    //   - EXPECTED OUTPUT: "You have input Apples as your keyword."
    //
    // * Add a Method to accept a string of words from the user. If the string is not empty, they have given a string.
    //   - PROMPT: "Please enter a series of words to check for your keyword."
    //   - EXPECTED SAMPLE INPUT: "Apples are a tasty fruit."
    //   - EXPECTED OUTPUT: "You have input 'Apples are a tasty fruit' as your word string."
    //
    // * Add a method to strip punctuation from a given sentence and return it in UPPERCASE.
    //   - EXPECTED SAMPLE INPUT: "Apples, I say, are a tasty fruit."
    //   - EXPECTED SAMPLE RETURN: "APPLES I SAY ARE A TASTY FRUIT"
    //
    // * Add the Method that counts the occurrences of the key word in the sentence (based on the REPL logic) and returns the number of occurrences.
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //   - EXPECTED OUTPUT: 3.
    //
    // * Create a RepeatCounter instance in the HomeController. (Not necessary but useful to use an instance) ?????
    //
    // * Create a View called Index.cshtml as a title screen.
    //
    // * Test the View Controller to make sure the View() Index works.
    //
    // * Get a key word from the user via a form on Index.cshtml and output it to the Console.
    //   - EXPECTED FORM INPUT: "Apples"
    //   - EXPECTED OUTPUT: "Apples"
    //
    // * Get a sentence from the user via a form on Index.cshtml and output it to the Console.
    //   - EXPECTED FORM INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //   - EXPECTED OUTPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //
    // * Test the View Controller to make sure the View() Index works when passing its model from the form to the page.
    //
    // * Get a keyword string from the User and pass it to RepeatCounter
    //   - EXPECTED FORM INPUT: "Apples"
    //   - NO OUTPUT
    //
    // * Get a string of words from the User and pass it to RepeatCounter
    //   - EXPECTED FORM INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //   - NO OUTPUT
    //
    // * Run the Counter Method on the inputted strings and output to the Index View.
    //   - EXPECTED INPUT: "Apples"
    //   - EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
    //   - EXPECTED OUTPUT: "Apples occurred 3 time(s) in the sentence you provided."

  }
}
