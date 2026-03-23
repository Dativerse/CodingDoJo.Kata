namespace TwoIntegerSum;

public class TwoKInterSumHashMapTest
{
    [Test]
    public void have_value_when_receive_array_left()
    {
        var input = ( new List<int> {1, 2, 3, 4}.ToArray(), 3);
        var expected = new[] { 1, 2 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_right()
    {
        var input = ( new List<int> {1, 2, 3, 4}.ToArray(), 7);
        var expected = new[] { 3, 4 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_middle()
    {
        var input = ( new List<int> {1, 3, 4, 5}.ToArray(), 7);
        var expected = new[] { 2, 3 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_mix_value_middle_negative()
    {
        var input = ( new List<int> { -11, -4, -2, -1, 0, 1, 4, 6, 16 }.ToArray(), -6);
        var expected = new[] { 2, 3 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_mix_value_left()
    {
        var input = ( new List<int> { -2, -1, 0, 4, 6 }.ToArray(), -1);
        var expected = new[] { 2, 3 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_mix_value_middle_positive()
    {
        var input = ( new List<int> { -11, -4, -2, -1, 0, 1, 4, 6, 16 }.ToArray(), 10);
        var expected = new[] { 7, 8 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_mix_value_right()
    {
        var input = ( new List<int> { -2, -1, 0, 4, 7 }.ToArray(), 4);
        var expected = new[] { 3, 4 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_mix_value_center()
    {
        var input = ( new List<int> { -2, -1, 0, 4, 7 }.ToArray(), 3);
        var expected = new[] { 2, 4 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_negative_left()
    {
        var input = ( new List<int> { -3, -2, -1, 0 }.ToArray(), -5);
        var expected = new[] { 1, 2 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_negative_middle()
    {
        var input = ( new List<int> { -11, -8, -2, -1, 0 }.ToArray(), -10);
        var expected = new[] { 2, 3 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void have_value_when_receive_array_with_negative_right()
    {
        var input = ( new List<int> { -15, -11, -9, -4 }.ToArray(), -13);
        var expected = new[] { 3, 4 };

        var result = TwoSum(input.Item1, input.Item2);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private static int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];
        var storage = new Dictionary<int, int>();

        for (var i = 0; i < numbers.Length; i++)
        {
            var range = target - numbers[i];

            if (storage.TryGetValue(range, out var index))
            {
                result[0] = index + 1;
                result[1] = i + 1;
                break;
            }
            
            storage.Add(numbers[i], i);
        }
        
        return result;
    }
}