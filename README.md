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

* Create a RepeatCounter Object model with a name and parameters. Simply test the object comes into existence. IsNotNull(Object) = true.
  - NO INPUT OR OUTPUT

* Add Getter for Keyword.
- EXPECTED INPUT: "Test"
- EXPECTED INPUT VIA OBJECT CONSTRUCTOR: "Test", "A Test Sentence."
- EXPECTED OUTPUT: None.

* Add Setter for Keyword.
- EXPECTED INPUT VIA OBJECT CONSTRUCTOR: "Test", "A Test Sentence."
- EXPECTED INPUT: "Banana"
- EXPECTED OUTPUT: None.

* Add Getter for Sentence.
- EXPECTED INPUT: "A Test Sentence.
- EXPECTED INPUT VIA OBJECT CONSTRUCTOR: "Test", "A Test Sentence."
- EXPECTED OUTPUT: None.

* Add Setter for Sentence.
- EXPECTED INPUT VIA OBJECT CONSTRUCTOR: "Test", "A Test Sentence."
- EXPECTED INPUT: "A Different Sentence."
- EXPECTED OUTPUT: None.

* Add a method to strip punctuation from a given sentence turning it into spaces.
  - EXPECTED SAMPLE INPUT: "Apples, I say, are a tasty fruit."
  - EXPECTED SAMPLE RETURN: "Apples, I say, are a tasty fruit"

* Add a Method that given a keyword and a sentence, turns the sentence to uppercase, splits at spaces, and counts the occurrences of the keyword in the sentence returning the count.
  - EXPECTED INPUT: "Apples"
  - EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
  - EXPECTED OUTPUT: 3.

* Create a RepeatCounter instance in the HomeController.

* Create a View called Index.cshtml as a title screen.

* Test the View Controller to make sure the View() Index works.

* Get a keyword from the user via a form on Index.cshtml and output it to the Console.
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

* Run the Counter Method on the inputted strings and output to the Index() View.
  - EXPECTED INPUT: "Apples"
  - EXPECTED INPUT: "Apples, I hear, are a tasty fruit. Apples are like any fruit. I like apples."
  - EXPECTED OUTPUT: "Apples occurred 3 time(s) in the sentence you provided."

* Style the Index page.

* Refactor code as needed.

## Methodology

* My approach is to take the word and the string of words and strip it of all punctuation. Then I convert both to uppercase and loop through the string of words comparing it to the keyword where I increment a counter if there's a match. Then I show the match count to the User.

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
