namespace _3SumTests;

public class ThreeSumTest
{
    [Test]
    public void normal_case()
    {
        int[] input = [-1, 0, 1, 2, -1, -4];
        int[][] expected = [[-1, -1, 2], [-1, 0, 1]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void case_000()
    {
        int[] input = [0, 0, 0];
        int[][] expected = [[0, 0, 0]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void case_0000()
    {
        int[] input = [0, 0, 0, 0];
        int[][] expected = [[0, 0, 0]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void case_11()
    {
        int[] input = [-2,0,1,1,2];
        int[][] expected = [[-2,0,2],[-2,1,1]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void case_22()
    {
        int[] input = [-2,0,0,2,2];
        int[][] expected = [[-2,0,2]];

        var result = ThreeSum(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    private List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        for (var i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1] || nums[i] > 0)
            {
                continue;
            }
            
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right) {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum > 0) {
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }
                }
            }
        }

        return result;
    }
    
}