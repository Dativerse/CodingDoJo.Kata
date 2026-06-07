namespace ContainerWithMostWaterTests;

public class ContainerWithMostWaterTest
{
    [Test]
    public void when_call_return_result()
    {
        int[] input = [1,7,2,5,4,7,3,6];
        var expected = 36;

        var result = MaxArea(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    private int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;

        var maxAmount = 0;

        while (left < right) {
            var height = heights[left];
            if (heights[right] < height) {
                height = heights[right];
            }

            var range = right - left;
            var amount = height * range;

            if (amount > maxAmount) {
                maxAmount = amount;
            }
            
            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        } 

        return maxAmount;
    }
}