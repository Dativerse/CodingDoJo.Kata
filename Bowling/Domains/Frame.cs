namespace Bowling.Domains;

public class Frame
{
    private int _firstRollScore { get; }

    private int _secondRollScore { get; }
    
    public Frame(string rawFrame)
    {
        _firstRollScore = int.Parse(rawFrame.Substring(0, 1));
        _secondRollScore = int.Parse(rawFrame.Substring(1, 1));
    }
    
    public int GetScore()
    {
        return _firstRollScore + _secondRollScore;
    }
}