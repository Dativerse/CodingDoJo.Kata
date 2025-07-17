namespace Bowling.Domains;

public class Frame
{
    private int _firstRollScore { get; }

    private int _secondRollScore { get; }
    
    private int _thirdRollScore { get; }
    
    public FrameType FrameType { get; set; }

    public Frame(string rawFrame)
    {
        if (rawFrame.Contains('/'))
        {
            FrameType = FrameType.Spare;
        }

        if (rawFrame.Contains('X'))
        {
            FrameType = FrameType.Strike;
        }
        
        _firstRollScore = ParseScore(rawFrame.Substring(0, 1));

        _secondRollScore = rawFrame.Length < 2 ? 0: ParseScore(rawFrame.Substring(1, 1));
        
        _thirdRollScore = rawFrame.Length < 3 ? 0 : ParseScore(rawFrame.Substring(2, 1));
    }

    private int ParseScore(string rawScore)
    {
        return rawScore switch
        {
            "-" => 0,
            "X" => 10,
            "/" => 10 - _firstRollScore,
            _ => int.Parse(rawScore)
        };
    }

    public int GetScore()
    {
        return _firstRollScore + _secondRollScore + _thirdRollScore;
    }

    public int FirstScore => _firstRollScore;
    public int SecondScore => _secondRollScore;
}

public enum FrameType
{
    Normal = 0,
    Spare = 1,
    Strike = 2,
}