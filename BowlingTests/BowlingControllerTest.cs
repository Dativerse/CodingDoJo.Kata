﻿using Bowling.Controllers;

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
    
    [Theory]
    [TestCase("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5-", 140, Description = "All spare frames and normal in final")]
    [TestCase("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 54 5-", 134, Description = "All spare frames and normal in final")]
    public void CalculateScore_WithSpareFrames_ReturnsExpectedScore(string frames, int expectedScore)
    {
        // Act
        var result = _controller.Calculate(frames);
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedScore));
    }
    
    [Theory]
    [TestCase("X X X X X X X X X 5-", 255, Description = "All strike frames and normal in final")]
    [TestCase("X X X X X X X X 45 5-", 237, Description = "All strike frames and normal in final")]
    [TestCase("X X 45 X X X X X 45 5-", 199, Description = "All strike frames and normal in final")]
    public void CalculateScore_WithStrikeFrames_ReturnsExpectedScore(string frames, int expectedScore)
    {
        // Act
        var result = _controller.Calculate(frames);
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedScore));
    }
}