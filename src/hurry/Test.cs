using hurry.Helpers;

namespace hurry;

public static class Test
{
    private static int _results;

    public static void Start()
    {
        PromptHelper.GetPrompt();
        TimeHelper.Start();
        var input = Console.ReadLine();
        TimeHelper.Stop();
        _results = ScoreHelper.GetScore(input!);
    }

    public static int GetResults()
    {
        return _results;
    }
}