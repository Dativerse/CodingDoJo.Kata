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
        var productSize = nums.Length;
        if (productSize <= 1)
        {
            return nums;
        }
        
        var result = new int[productSize];
        Array.Fill(result, 1);

        result[0] = nums[0];
        for (var i = 1; i < productSize; i++)
        {
            result[i] = result[i - 1] * nums[i];
        }
        
        result[productSize - 1] = result[productSize - 2];
        
        var suffix = nums[productSize - 1];
        for (var i = productSize - 2; i > 0; i--)
        {
            result[i] = result[i - 1] * suffix;
            suffix = nums[i] * suffix;;
        }
        result[0] = suffix;

        return result;
    }
}