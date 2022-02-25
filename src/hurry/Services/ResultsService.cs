using hurry.Models;

namespace hurry.Services;

public interface IResultsService
{
    int CalculateWpm(Test test);
}
public class ResultsService : IResultsService
{
    public int CalculateWpm(Test test)
    {
        try
        {
            // TODO: calculate wpm accurately
            var wordCount = test.UserInput.Length / 5L;
            var wordsPerSecond = wordCount / test.SecondsElapsed;
            var results = (int) wordsPerSecond * 60;

            return results;
        }
        catch (Exception)
        {
            Console.WriteLine("An error occurred when attempting to calculate WPM.");
            return 0;
        }
    }
}