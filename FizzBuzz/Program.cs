var fizzBuzzDetector = new FizzBuzzDetector();

Console.WriteLine("Enter a string (7 to 100 characters): ");
string inputString = Console.ReadLine();

try
{
    var result = fizzBuzzDetector.GetOverlappings(inputString);
    Console.WriteLine($"Processed String: {result.OutputString}");
    Console.WriteLine($"Count of Fizz/Buzz/FizzBuzz: {result.Count}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}