// See https://aka.ms/new-console-template for more information

Console.WriteLine("Case 1: [\"X\"] => [[\"X\"]]");
Console.WriteLine($"Result: {GroupAnagrams(["X"])}");

Console.WriteLine("Case 2: [\"\"] => [[\"\"]]");
Console.WriteLine($"Result: {GroupAnagrams([""])}");
Console.WriteLine("---------------");
Console.WriteLine("Case 3: [\"cat\", \"hat\"] => [[\"cat\"], [\"hat\"]]");
Console.WriteLine($"Result: {GroupAnagrams(["cat", "hat"])}");
Console.WriteLine("---------------");
Console.WriteLine("Case 4: [\"cat\", \"tac\"] => [[\"cat\", \"tac\"]]");
Console.WriteLine($"Result: {GroupAnagrams(["cat", "tac"])}");
Console.WriteLine("---------------");
Console.WriteLine("Case 5: [\"cat\", \"tac\", \"hat\"] => [[\"cat\", \"tac\"], [\"hat\"]]");
Console.WriteLine($"Result: {GroupAnagrams(["cat", "tac", "hat"])}");

return;

List<List<string>> GroupAnagrams(string[] strs) {
    var result = new Dictionary<string, List<string>>();
    
    foreach (var str in strs)
    {
        var characters = str.ToArray();
        Array.Sort(characters);
        var key = new string(characters);
        
        if (!result.ContainsKey(key))
        {
            result[key] = [str];
        }
        else
        {
            result[key].Add(str);
        }
    }
    
    return result.Select(str => str.Value).ToList();
}