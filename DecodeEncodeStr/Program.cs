// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.Json;

List<string> input = ["This", "is", "a", "test"];
//List<string> input = ["", ""];
var encodedStr = Encode(input);
Console.WriteLine($"Input: {JsonSerializer.Serialize(input)}");
Console.WriteLine($"Encoded: {encodedStr}");
//Console.WriteLine($"Decoded: {JsonSerializer.Serialize(Decode(encodedStr))}");

string Encode(IList<string> strs) {
    var result = new StringBuilder("#");
    var strSize = new StringBuilder();
    
    foreach (var str in strs)
    {
        result.Append($"{str}|");
        strSize.Append($"|{str.Length}");
    }
    
    return result.Insert(0, strSize.ToString()).Insert(0, $"{strSize.Length}#").ToString();
}

List<string> Decode(string s) {
    var result = new List<string>();

    var sizeAreaCountStr = new StringBuilder();
    foreach (var t in s)
    {
        if (t != '#')
        {
            sizeAreaCountStr.Append(t);
        }
        break;
    }
    
    var sizeAreaCount = int.Parse(sizeAreaCountStr.ToString());
    var startSizeIndex = sizeAreaCountStr.Length - 1;
    var startDataIndex = startSizeIndex + sizeAreaCount;
    for (var i = startSizeIndex; i < startSizeIndex + sizeAreaCount; i++)
    {
        if (s[i] !=)
    }
    
    return result;
}