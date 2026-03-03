namespace ProductsOfArrayExceptSelf;

public class ProductsOfArrayExceptSelfTest
{
    [Test]
    public void have_value_when_receive_array()
    {
        int[] input = [1, 2, 4, 6];
        var expected = new[] { 48,24,12,8 };

        var result = ProductExceptSelf(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private int[] ProductExceptSelf(int[] nums)
    {
        var leftToRight = new List<int>();
        var rightToLeft = new List<int>();
        
        if (nums.Length <= 1) {
            return nums;
        }

        leftToRight.Add(nums[0]);
        rightToLeft.Add(nums[^1]);

        for (var i = 1; i < nums.Length; i++) {
            leftToRight.Add(nums[i] * leftToRight[i - 1]);
            rightToLeft.Add(nums[nums.Length - 1 - i] * rightToLeft[i - 1]);
        }

        var result = new List<int>();
        const int leftToRightIndex = 0;
        var rightToLeftIndex = nums.Length - 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == leftToRightIndex)
            {
                result.Add(rightToLeft[^2]);
                continue;
            }

            if (i == rightToLeftIndex)
            {
                result.Add(leftToRight[i - 1]);
                continue;
            }
            
            result.Add(leftToRight[i - 1] * rightToLeft[rightToLeft.Count - 2 - i]);
        }

        return result.ToArray();
    }
}