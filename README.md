# Python Documentation

# Python Regex Tester

This Python script allows you to test regular expressions (regex) against a string of your choice. It's a simple and quick way to validate and debug your regex patterns.

## How it works

When you run the script, it will first ask you to enter your regex pattern. After that, it will ask you to enter a string that you want to test against the regex pattern. The script will then search for the pattern in the string and print out the result.

If a match is found, it will print "Match found: " followed by the matched string. If no match is found, it will print "No match found." After that, it will ask if you want to continue. If you enter 'y', it will start over, otherwise it will exit.

## Imported Libraries

The script uses the following Python library:

- `re`: This is Python's built-in module for working with regular expressions. It provides functions to search, split and replace strings based on regex patterns. In this script, we use the `re.search()` function to search for the regex pattern in the test string.

## Usage

To use the script, simply run it in your Python environment. When prompted, enter your regex pattern and the string you want to test. The script will then print out the result.

```python
python regex_tester.py
```

## Example

Here is an example of how to use the script:

```
Enter your regex: \d+
Enter a string to test: Hello123
Match found: 123
Continue? (y/n): n
```

In this example, the regex pattern `\d+` matches one or more digits. The test string "Hello123" contains the substring "123" which matches the pattern, so the script prints "Match found: 123".

---

# C# Documentation

# CSharp Regex Matcher

This is a simple C# script that allows users to test regular expressions against input strings. The script will continue to prompt the user for a regex pattern and an input string until the user enters an empty pattern.

## Script Explanation

The script begins by importing two libraries:

- `System`: This is a fundamental library in C#, providing base functionalities such as Console I/O operations.
- `System.Text.RegularExpressions`: This library provides functionality for processing regular expressions in C#.

The script then defines a `Program` class with a `Main` method, which is the entry point for the application.

In the `Main` method, an infinite loop is started that will continue until the user enters an empty string for the regex pattern. Inside the loop, the script does the following:

1. Prompts the user to enter a regex pattern and reads the user's input.
2. If the pattern is an empty string, the script breaks out of the loop and ends.
3. If the pattern is not empty, the script prompts the user to enter some input to test against the pattern and reads the user's input.
4. The script then creates a `Regex` object using the pattern provided by the user.
5. The script tests the input against the regex pattern using the `IsMatch` method of the `Regex` object.
6. If a match is found, the script prints "Match found!" to the console. If no match is found, the script prints "No match found." to the console.

After printing the result, the script goes back to the start of the loop, prompting the user for another regex pattern.

## Usage

To use this script, simply run it in a C# environment (such as Visual Studio or .NET Core), and follow the prompts in the console. Enter a regex pattern and an input string to test against the pattern. The script will tell you whether a match was found or not. To end the script, enter an empty string when prompted for a regex pattern.

---

# Java Documentation

# Java Regex Practice Tester

This Java script is a simple console-based application that allows users to test regular expressions (regex) against input text. The script prompts the user to enter a regex pattern and then a text to search. It then uses the provided regex pattern to search the input text and displays the matching text along with its starting and ending indices. The script continues to prompt the user for new regex patterns and texts to search until the user enters "exit" as the regex pattern.

## Imported Libraries

The script uses the following Java libraries:

- `java.util.Scanner`: This library is used to read the user's input from the console. It provides methods to parse primitive types and strings using regular expressions, which makes it a good choice for this script.

- `java.util.regex.Pattern`: This library is a compiled representation of a regular expression. It provides methods to create a `Matcher` object that can match arbitrary character sequences against the regular expression.

- `java.util.regex.Matcher`: This library is an engine that performs match operations on a character sequence by interpreting a `Pattern`. It provides methods to check for matches, find the starting and ending indices of the match, and retrieve the matched text.

## Code Explanation

The script starts by creating a `Scanner` object to read the user's input. It then enters an infinite loop where it prompts the user to enter a regex pattern. If the user enters "exit", the script breaks out of the loop and ends. Otherwise, it compiles the regex pattern into a `Pattern` object.

Next, the script prompts the user to enter a text to search. It creates a `Matcher` object using the `Pattern` object and the input text. It then enters a loop where it uses the `Matcher` to find matches in the text. For each match, it prints the matched text and its starting and ending indices. If no match is found, it prints a message to that effect.

After processing the input text, the script goes back to the start of the loop and prompts the user for a new regex pattern. This continues until the user enters "exit" as the regex pattern.

---
