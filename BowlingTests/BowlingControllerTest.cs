using Bowling.Controllers;

namespace BowlingTests;

public class BowlingControllerTest
{
    private BowlingGameController _controller;

    [SetUp]
    public void Setup()
    {
        _controller = new BowlingGameController();
    }

   
    [Theory]
    [TestCase("54 45 45 45 45 45 45 45 45 45", 90, Description = "All normal frames")]
    [TestCase("9- 9- 81 9- 9- 9- 9- 9- 9- 9-", 90, Description = "All frames with 9 and miss")]
    public void CalculateScore_WithNormalFrames_ReturnsExpectedScore(string frames, int expectedScore)
    {
        // Act
        var result = _controller.Calculate(frames);
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedScore));
    }

    
}