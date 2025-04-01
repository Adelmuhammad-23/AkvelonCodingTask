
# FizzBuzzTask

## Overview
FizzBuzzProcessor is a C# program designed to process an input string, modifying it by replacing specific words with "Fizz," "Buzz," or "FizzBuzz" based on their positions in the string. It calculates and returns the number of such replacements, providing an efficient way to visualize the FizzBuzz problem in the context of string manipulation.

## Key Features:
- Replaces every word in the string at positions that are multiples of 3, 5, or both with "Fizz," "Buzz," or "FizzBuzz" respectively.
- Ignores extra spaces between words, ensuring accurate word processing.
- Handles empty strings gracefully by returning an appropriate error message.
- Accepts strings of length between 7 and 100 characters, throwing an exception for invalid lengths.

## How it Works:
1. The program processes an input string, splitting it into words.
2. Based on the position of each word, it replaces the word with "Fizz," "Buzz," or "FizzBuzz" depending on divisibility.
3. The program counts the total number of replacements and outputs the modified string along with the count.

## Example:
### Input:
"The   quick brown    fox jumps   over the lazy  dog"

### Processed Output:
"The quick Fizz fox Buzz Fizz the lazy Fizz"

### Count of Fizz/Buzz/FizzBuzz:
4

## Requirements:
- .NET SDK (any supported version)
- C# compiler to run the program

## How to Run:
1. Clone the repository.
    ```bash
     git clone https://github.com/Adelmuhammad-23/AkvelonCodingTask.git
     ```
2. Compile and run the program using the .NET SDK.
3. Input a string within the length limits (7 to 100 characters) to see the processed output.
