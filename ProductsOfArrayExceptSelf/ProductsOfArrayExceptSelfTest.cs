namespace ProductsOfArrayExceptSelf;

public class ProductsOfArrayExceptSelfTest
{
    [Test]
    public void have_value_when_receive_array_1()
    {
        int[] input = [1, 2, 4, 6];
        var expected = new[] { 48, 24, 12, 8 };

        var result = ProductExceptSelf(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_2()
    {
        int[] input = [-1, 0, 1, 2, 3];
        var expected = new[] { 0, -6, 0, 0, 0 };

        var result = ProductExceptSelf(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private int[] ProductExceptSelf(int[] nums)
    {
        if (nums.Length <= 1) {
            return nums;
        }
        
        var leftToRight = new int[nums.Length];
        leftToRight[0] = nums[0];
        
        var rightToLeft = new int[nums.Length];
        rightToLeft[0] = nums[^1];

        for (var i = 1; i < nums.Length; i++) {
            leftToRight[i] = nums[i] * leftToRight[i - 1];
            rightToLeft[i] = nums[nums.Length - 1 - i] * rightToLeft[i - 1];
        }

        // pre-process with item at index 0
        var result = new int[nums.Length];
        result[0] = rightToLeft[^2];
        
        // merge LeftToRight storage with RightToLeft storage
        for (var i = 1; i < nums.Length - 1; i++)
        {
            result[i] = leftToRight[i - 1] * rightToLeft[rightToLeft.Length - 2 - i];
        }
        
        // post-process with item at last index
        result[nums.Length - 1] = leftToRight[nums.Length - 2];

        return result.ToArray();
    }
}