namespace Bowling.Domains;

public class Frame
{
    private int _firstRollScore { get; }

    private int _secondRollScore { get; }
    public FrameType FrameType { get; set; }

    public Frame(string rawFrame)
    {
        if (rawFrame.Contains('/'))
        {
            FrameType = FrameType.Spare;
        }
        
        _firstRollScore = ParseScore(rawFrame.Substring(0, 1));

        _secondRollScore = ParseScore(rawFrame.Substring(1, 1));
    }

    private int ParseScore(string rawScore)
    {
        switch (rawScore)
        {
            case "-"://Miss
                return 0;
            case "/"://Spare
                return 10 - _firstRollScore;
            default:
                return int.Parse(rawScore);
        }
    }

    public int GetScore()
    {
        return _firstRollScore + _secondRollScore;
    }

    public int FirstScore => _firstRollScore;
}

public enum FrameType
{
    Normal = 0,
    Spare = 1,
    Strike = 2,
}