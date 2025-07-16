using Bowling.Controllers;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Constraints;

namespace BowlingTests;

public class BowlingControllerTest
{
    private BowlingGameController _controller;

    [SetUp]
    public void Setup()
    {
        _controller = new BowlingGameController();
    }

    [Test]
    public void normal_when_34_before_normal_frame()
    {
        var result = _controller.Calculate("45 45 45 45 45 45 45 45 45 45");
        
        Assert.That(result, Is.EqualTo(90));
    }
}