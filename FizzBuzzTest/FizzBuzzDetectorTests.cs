public class FizzBuzzDetectorTests
{
    private readonly FizzBuzzDetector _detector = new FizzBuzzDetector();

    [Fact]
    public void Should_Handle_Short_Input_Correctly()
    {
        string input = "A B C D E F G";
        var result = _detector.GetOverlappings(input);

        string expectedOutput = "A B Fizz D Buzz Fizz G";
        Assert.Equal(expectedOutput, result.OutputString);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void Should_Ignore_Extra_Spaces_And_Process_Words_Correctly()
    {
        string input = "The   quick brown    fox jumps   over the lazy  dog";
        var result = _detector.GetOverlappings(input);

        string expectedOutput = "The quick Fizz fox Buzz Fizz the lazy Fizz";
        Assert.Equal(expectedOutput, result.OutputString);
        Assert.Equal(4, result.Count);
    }

    [Fact]
    public void Should_Handle_Empty_Input_Correctly()
    {
        string input = "";

        var exception = Assert.Throws<ArgumentException>(() => _detector.GetOverlappings(input));

        Assert.Equal("Input string length must be between 7 and 100 characters.", exception.Message);
    }


    [Fact]
    public void Should_Return_Same_String_When_No_Replacements_Are_Needed()
    {
        string input = "One Two Four Seven Eight Eleven Thirteen Fourteen";
        var result = _detector.GetOverlappings(input);

        string expectedOutput = "One Two Fizz Seven Buzz Fizz Thirteen Fourteen";
        Assert.Equal(expectedOutput, result.OutputString);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void Should_Throw_Exception_For_Invalid_Input_Length()
    {
        string shortInput = "Short";
        string longInput = new string('A', 101);

        Assert.Throws<ArgumentException>(() => _detector.GetOverlappings(shortInput));
        Assert.Throws<ArgumentException>(() => _detector.GetOverlappings(longInput));
    }
}
