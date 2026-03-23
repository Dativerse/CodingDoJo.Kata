namespace _3SumTests;

public class ThreeSumTest
{
    [Test]
    public void three_sum_when_0_0_0_return_one_triplet()
    {
        int[] input = [0, 0, 0];
        int[][] expected = [[0, 0, 0]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void three_sum_when_all_negative_return_empty()
    {
        int[] input = [-4, -1, -1];
        int[][] expected = [];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void three_sum_when_all_positive_return_empty()
    {
        int[] input = [4, 1, 1];
        int[][] expected = [];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void three_sum_when_have_0_return_pair()
    {
        int[] input = [9, -4, 0, -1, 4, 1, -6];
        int[][] expected = [[-1, 0, 1], [-4, 0, 4]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void three_sum_when_call_return_triplets()
    {
        int[] input = [4, -3, 9, -6, 1, -1];
        int[][] expected = [[-6, -3, 9], [-3, -1, 4]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void three_sum_when_have_dupplicated_return_dupplicated()
    {
        int[] input = [9, -4, 0, -1, 4, -6, -1, 1, -4];
        int[][] expected = [[-1, 0, 1], [-1, 0, 1], [-4, 0, -4], [-4, 0, -4]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    private List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>>();

        return result;
    }
}