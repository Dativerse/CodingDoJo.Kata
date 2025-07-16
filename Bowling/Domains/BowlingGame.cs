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
        foreach (var frame in _frames)
        {
            finalResult += frame.GetScore();
        }
        
        return finalResult;
    }
}