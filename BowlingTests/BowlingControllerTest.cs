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
    [TestCase("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 54 5-", 134, Description = "All spare frames and normal in final")]
    [TestCase("X X 45 X X X X X 45 5-", 199, Description = "All strike frames and normal in final")]
    [TestCase("X X 45 X X 7/ X X 45 5-", 176, Description = "All strike frames with spare and normal in final")]
    public void CalculateScore_WithFrames_ReturnsExpectedScore(string frames, int expectedScore)
    {
        // Act
        var result = _controller.Calculate(frames);
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedScore));
    }
}