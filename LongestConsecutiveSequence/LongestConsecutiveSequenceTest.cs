namespace LongestConsecutiveSequence;

public class LongestConsecutiveSequenceTest
{
    [Test]
    public void have_value_when_receive_array_1()
    {
        int[] input = [2,20,4,10,3,4,5];
        var expected = 4; // The longest consecutive sequence is [2, 3, 4, 5]

        var result = LongestConsecutive(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_2()
    {
        int[] input = [0,3,2,5,4,6,1,1];
        var expected = 7; // [0, 1, 2, 3, 4, 5, 6]

        var result = LongestConsecutive(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        
        var storage = new HashSet<int>(nums);
        var longest = 1;
        foreach (var num in storage)
        {
            if (!storage.Contains(num - 1)) continue;
            
            var lenght = 2;
            var  current = num;
            while (storage.Contains(current + 1))
            {
                lenght++;
                current++;
            }

            if (lenght > longest)
            {
                longest = lenght;
            }
        }

        return longest;
    }
}