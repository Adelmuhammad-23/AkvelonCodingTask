using FizzBuzz;

public class FizzBuzzDetector
{
    public FizzBuzzResult GetOverlappings(string inputString)
    {
        if (string.IsNullOrEmpty(inputString) || inputString.Length < 7 || inputString.Length > 100)
        {
            throw new ArgumentException("Input string length must be between 7 and 100 characters.");
        }

        List<string> outputWords = new List<string>();
        int wordIndex = 1;

        string currentWord = "";
        bool inWord = false;

        foreach (char c in inputString)
        {
            if (c == ' ')
            {
                if (inWord)
                {
                    ProcessWord(currentWord, wordIndex, outputWords);
                    wordIndex++;
                    currentWord = "";
                    inWord = false;
                }
            }
            else
            {
                currentWord += c;
                inWord = true;
            }
        }

        if (inWord)
        {
            ProcessWord(currentWord, wordIndex, outputWords);
        }

        string outputString = "";

        foreach (string word in outputWords)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                if (outputString.Length > 0)
                    outputString += " ";
                outputString += word;
            }
        }

        return new FizzBuzzResult
        {
            OutputString = outputString,
            Count = outputWords.Count(word => word == "Fizz" || word == "Buzz" || word == "FizzBuzz")
        };
    }

    private void ProcessWord(string word, int wordIndex, List<string> outputWords)
    {
        string cleanedWord = CleanWord(word);

        if (!string.IsNullOrEmpty(cleanedWord))
        {
            if (wordIndex % 15 == 0)
            {
                outputWords.Add("FizzBuzz");
            }
            else if (wordIndex % 3 == 0)
            {
                outputWords.Add("Fizz");
            }
            else if (wordIndex % 5 == 0)
            {
                outputWords.Add("Buzz");
            }
            else
            {
                outputWords.Add(word);
            }
        }
        else
        {
            outputWords.Add(word);
        }
    }

    private string CleanWord(string word)
    {
        int start = 0;
        int end = word.Length - 1;

        while (start < word.Length && !IsLetterOrDigit(word[start]))
        {
            start++;
        }

        while (end >= 0 && !IsLetterOrDigit(word[end]))
        {
            end--;
        }

        if (start <= end)
        {
            return word.Substring(start, end - start + 1);
        }

        return string.Empty;
    }

    private bool IsLetterOrDigit(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }
}

