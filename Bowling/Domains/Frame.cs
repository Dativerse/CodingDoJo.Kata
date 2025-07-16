namespace Bowling.Domains;

public class Frame
{
    private int _firstRollScore { get; }

    private int _secondRollScore { get; }

    public Frame(string rawFrame)
    {
        _firstRollScore = ParseScore(rawFrame.Substring(0, 1));

        _secondRollScore = ParseScore(rawFrame.Substring(1, 1));
    }

    private static int ParseScore(string rawScore)
    {
        return rawScore.Equals("-") ? 0 : int.Parse(rawScore);
    }

    public int GetScore()
    {
        return _firstRollScore + _secondRollScore;
    }
}