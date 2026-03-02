// See https://aka.ms/new-console-template for more information

using System.Text.Json;

Console.WriteLine(JsonSerializer.Serialize(TopKFrequent([1, 1, 2, 3, 1, 2, 4, 5, 2, 1], 2)));

int[] TopKFrequent(int[] nums, int k)
{
    var numStorage = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (numStorage.TryGetValue(num, out var savedNum))
        {
            numStorage[num] = savedNum + 1;
        }
        else
        {
            numStorage.Add(num, 1);
        }
    }
    
    var q = new PriorityQueue<int, int>();

    return numStorage.OrderByDescending(k => k.Value)
        .Take(k)
        .Select(k => k.Key)
        .ToArray();
}