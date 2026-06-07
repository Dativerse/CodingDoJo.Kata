namespace TrappingRainWaterTests;

public class TrappingRainWaterTest
{

    [Test]
    public void Test1()
    {
        int[] input = [0,2,0,3,1,0,1,3,2,1];
        var expected = 9;

        var result = Trap(input);
        
        Assert.That(result, Is.EqualTo(expected));    
    }
    
    [Test]
    public void Test2()
    {
        int[] input = [0,1,0,2,1,0,1,3,2,1,2,1];
        var expected = 6;

        var result = Trap(input);
        
        Assert.That(result, Is.EqualTo(expected));    
    }
    
    [Test]
    public void Test3()
    {
        int[] input = [2, 0, 2];
        var expected = 2;

        var result = Trap(input);
        
        Assert.That(result, Is.EqualTo(expected));    
    }
    
        
    [Test]
    public void Test4()
    {
        int[] input = [5,4,1,2];
        var expected = 1;

        var result = Trap(input);
        
        Assert.That(result, Is.EqualTo(expected));    
    }
    
    private int Trap(int[] height) {

    }
}