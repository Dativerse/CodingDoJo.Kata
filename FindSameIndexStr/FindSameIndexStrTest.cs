namespace FindSameIndexStr;

public class FindSameIndexStrTest
{
    [Test]
    public void have_value_when_receive_array_1()
    {
        string[] input = ["abc", "def", "xyz", "heh"];
        var expected = new List<int>{1, 3, 1};

        var result = FindSameIndexStr(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }    
    
    [Test]
    public void have_value_when_receive_array_2()
    {
        string[] input = ["abcea", "bafga", "hbjka"];
        var expected = new List<int>{0, 2, 1};

        var result = FindSameIndexStr(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    List<int> FindSameIndexStr(string[] input)
    {
        var result = new List<int>();
        var strSize = input[0].Length;

        for (var strIndex = 0; strIndex < strSize; strIndex++)
        {
            var storage = new Dictionary<char, int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (storage.ContainsKey(input[i][strIndex]))
                {
                    return [storage[input[i][strIndex]], i, strIndex];
                }
                storage.Add(input[i][strIndex], i);
            }
        }
        
        return result;
    }
}