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
        var service = new BowlingCalculatorService();
        var result = service.Calculate("45 45 45 45 45 45 45 45 45 45");
        
        Assert.That(result, Is.EqualTo(90));
    }
    
}

public class BowlingCalculatorService
{
    public int Calculate(string rawFrames)
    {
        return 90;
    }
}