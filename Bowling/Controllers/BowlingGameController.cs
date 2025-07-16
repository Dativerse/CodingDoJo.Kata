using Bowling.Domains;

namespace Bowling.Controllers;

public class BowlingGameController
{
    public int Calculate(string rawFrames)
    {
        var bowlingGame = new BowlingGame(rawFrames);
        
        return bowlingGame.GetGameResult();
    }
}