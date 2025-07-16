namespace Bowling.Domains;

public class BowlingGame(string rawFrames)
{
    private readonly List<Frame> _frames = rawFrames
        .Split(" ")
        .Select(frame => new Frame(frame))
        .ToList();
    
    public int GetGameResult()
    {
        var finalResult = 0;

        for (var i = 0; i < _frames.Count; i++)
        {
            if (_frames[i].FrameType is FrameType.Spare)
            {
                finalResult += 10;
                finalResult += _frames[i + 1].FirstScore;
            }
            else if (_frames[i].FrameType is FrameType.Strike)
            {
                finalResult += 10;
                finalResult += _frames[i + 1].FirstScore;
                if (_frames[i + 1].FrameType is FrameType.Strike)
                {
                    finalResult += _frames[i + 2].FirstScore;
                }
                else
                {
                    finalResult += _frames[i + 1].SecondScore;
                }
            }
            else
            {
                finalResult += _frames[i].GetScore();
            }
        }

        return finalResult;
    }
}