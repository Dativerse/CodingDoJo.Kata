using Bowling.Controllers;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Constraints;

namespace BowlingTests;

public class BowlingControllerTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void normal_when_34_before_normal_frame()
    {
        var controller = new BowlingGameController();
        var result = controller.Calculate("45 45 45 45 45 45 45 45 45 45");
        
        Assert.That(result, Is.EqualTo(90));
    }
}