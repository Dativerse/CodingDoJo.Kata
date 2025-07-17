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

        for (var i = 0; i < _frames.Count - 1; i++)
        {
            switch (_frames[i].FrameType)
            {
                case FrameType.Spare:
                    finalResult += 10 + _frames[i + 1].FirstScore;
                    break;
                case FrameType.Strike:
                {
                    finalResult += 10;
                    finalResult += _frames[i + 1].FirstScore;
                    if (_frames[i + 1].FrameType is FrameType.Strike)
                    {
                        finalResult += _frames[i + 2].FirstScore;
                        break;
                    }
                    
                    finalResult += _frames[i + 1].SecondScore;
                    break;
                }
                case FrameType.Normal:
                default:
                    finalResult += _frames[i].GetScore();
                    break;
            }
        }
        
        finalResult += _frames.Last().GetScore();

        return finalResult;
    }
}