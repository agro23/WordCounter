# Word Counter

#### By Andy Grossberg

## Description

A program for a User to enter a keyword and a string of words where the program counts how many times the ,keyword occurs in the string.

## Rules

Word Counter
Your mission is to create a website in MVC that uses a method to return how frequently a word appears in a given string. The user should input both the word and the string of words to check. Check for full word matches only.

Before writing any code, start by writing specs in English in a plain text file, just like we've been doing in class (listing them in the README is fine). Commit your English specs before beginning on your code.

Each spec should include a specific input and output pair, as well as a description sentence explaining why you chose that specific input value as the simplest way to test the behavior your spec is covering.

After you're done with your English specs, go through them one by one and translate each one into a test method for MSTest. After writing a test method, make it pass. Remember to commit as you go, and do not start writing your MVC app until after you have made all your tests pass.

Create a class called RepeatCounter. This class should contain logic for counting how many times a word appears in a string of words. Using more than one method to do this could make your logic easier to test. For instance, you might have one method for testing whether the user's input is valid and one method for actually searching the string of words.

After you are finished writing your RepeatCounter methods, create an MVC app to demonstrate it working. It should have a form and a spot for results. You can use a single view or two views.

Before writing the logic for your controller actions, make sure to write tests for them. For each view you should have a test that checks that the action returns a view and a test that checks that the model for the view is correct. Remember that we can test HttpGet actions but we cannot HttpPost actions.

Do not use regular expressions in your logic.

## Specifications

* Take input of a key word from the User via REPL, output it to Console. If the string is not empty it should pass the test.
- EXPECTED INPUT: "Apple"
- EXPECTED OUTPUT: "Apple"

* Take input of a string from the User via REPL, output it to Console. If the string is not empty it should pass the test.
- EXPECTED INPUT: "Apples are a tasty fruit."
- EXPECTED OUTPUT: "Apples are a tasty fruit."

* Strip punctuation from the string and output the resulting punctuation-free to the Console. Punctuation should not effect the words to count.
  (This will be done by running through the sentence a character at a time and writing anything that isn't punctuation to a new string.). To test if it succeeded a string with punctuation should be input and then check the new string to see if it contains sample punctuation.
- EXPECTED INPUT: "Apples, I hear, are a tasty fruit."
- EXPECTED OUTPUT: "Apples I hear are a tasty fruit"

* Split the new word string at " " into an array of strings called "sentence" and output it to the Console. This is the array we will compare the key word to in order to count its occurrences. If the array is not empty and its words contain no spaces it will pass the test.
- EXPECTED INPUT: "Apples, I hear, are a tasty fruit."
- EXPECTED OUTPUT:
    - Apples
    - I
    - hear
    - are
    - a
    - tasty
    - fruit

* Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
  TESTING: The counter is 0 when a string with no matches to the keyword is entered. Output the counter.:
  - EXPECTED INPUT: "Bananas"
  - EXPECTED INPUT: "Apples, I hear, are a tasty fruit."
  - EXPECTED OUTPUT: 0.

* Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
- TESTING: The repeat counter should be > 0 if a sentence of just the keyword repeated 5, or 3 times, or 12 times, etc. is entered. Output the counter.:
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples APPLEs Apples APPLES apples."
- EXPECTED OUTPUT: 5.
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples, APPLES, apples."
- EXPECTED OUTPUT: 3.
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples; APPLEs: Apples APPLES apples Apples, APPLES, apples Apples, APPLES, apples ApPlEs!"
- EXPECTED OUTPUT: 12.

* Use a for loop ending at the length of the "sentence" array to run through it word by word. Increment a counter for every time that a word in the array matches the key word. NOTE: Both the Key and Sentence Word will be rendered to upper case during the comparison.
- TESTING: If a string that includes the keyword a few random times where the counter should be equal to the number of keywords I enter to pass.:
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
- EXPECTED OUTPUT: 3.

* Tell the user with a sentence how many times the word has occurred in the sentence.
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples are a tasty fruit."
- EXPECTED OUTPUT: "Apples occurred 1 time(s) in the sentence you provided."

* Create a RepeatCounter Object model with a name. Simply test the object comes into existence. IsNotNull(Object) = true.
- NO INPUT OR OUTPUT

* Add Getters, and Setters as needed. Test them by getting and setting vars and passing them back and forth.
- NO INPUT OR OUTPUT

* Add a Method to accept a key word from the user. If the string is not empty, they have given a keyword.
- PROMPT: "Please enter a keyword."
- EXPECTED SAMPLE INPUT: "Apples"
- EXPECTED OUTPUT: "You have input Apples as your keyword."

* Add a Method to accept a string of words from the user. If the string is not empty, they have given a string.
- PROMPT: "Please enter a series of words to check for your keyword."
- EXPECTED SAMPLE INPUT: "Apples are a tasty fruit."
- EXPECTED OUTPUT: "You have input 'Apples are a tasty fruit' as your word string."

* Add a method to strip punctuation from a given sentence and return it in UPPERCASE.
- EXPECTED SAMPLE INPUT: "Apples, I say, are a tasty fruit."
- EXPECTED SAMPLE RETURN: "APPLES I SAY ARE A TASTY FRUIT"

* Add the Method that counts the occurrences of the key word in the sentence (based on the REPL logic) and returns the number of occurrences.
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
- EXPECTED OUTPUT: 3.

* Create a RepeatCounter instance in the HomeController. (Not necessary but useful to use an instance) ?????

* Create a View called Index.cshtml as a title screen.

* Test the View Controller to make sure the View() Index works.

* Get a key word from the user via a form on Index.cshtml and output it to the Console.
- EXPECTED FORM INPUT: "Apples"
- EXPECTED OUTPUT: "Apples"

* Get a sentence from the user via a form on Index.cshtml and output it to the Console.
- EXPECTED FORM INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
- EXPECTED OUTPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."

* Test the View Controller to make sure the View() Index works when passing its model from the form to the page.

* Get a keyword string from the User and pass it to RepeatCounter
- EXPECTED FORM INPUT: "Apples"
- NO OUTPUT

* Get a string of words from the User and pass it to RepeatCounter
- EXPECTED FORM INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
- NO OUTPUT

* Run the Counter Method on the inputted strings and output to the Index View.
- EXPECTED INPUT: "Apples"
- EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
- EXPECTED OUTPUT: "Apples occurred 3 time(s) in the sentence you provided."

* Refactor code as needed.

## Methodology

* My approach is to take the word and the string of words and strip it all of punctuation. Then I convert both to uppercase and loop through the string of words comparing it to the keyword where I increment a counter if there's a match. Then I show the match count to the User.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/agro23/WordCounter.git'.
* Run the command 'dotnet restore' to download the necessary packages.
* Run the command 'dotnet build' to build to build the app.
* Run the command 'dotnet run' to run the server on localhost.
* Use your preferred web browser to navigate to localhost:5000

## Support and contact details

* Contact the author at andy.grossberg@gmail.com

## Technologies Used

* C#
* Asp .NET Core 1.1 MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Andy Grossberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
