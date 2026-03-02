using System.Collections;
using System.Text;

namespace DecodeEnCode;

[TestFixture]
public class Tests
{
    [Test]
    public void encode_when_get_empty_list()
    {
        var input = new List<string> { "", "" };
        Assert.That(Encode(input), Is.EqualTo("3#0|0#"));
    }
    [Test]
    public void encode_when_get_only_1_empty_str()
    {
        var input = new List<string> { "" };
        Assert.That(Encode(input), Is.EqualTo("1#0#"));
    }
    [Test]
    public void encode_when_get_only_1_str()
    {
        var input = new List<string> { "Str!@|#" };
        Assert.That(Encode(input), Is.EqualTo("1#7#Str!@|#"));
    }
    [Test]
    public void encode_when_get_list()
    {
        var input = new List<string> { "Str!@|#", "ThisIsString" };
        Assert.That(Encode(input), Is.EqualTo("4#7|12#Str!@|#ThisIsString"));
    }

    [Test]
    public void decode_when_get_only_1_empty_str()
    {
        var input = "1#0#||";
        Assert.That(Decode(input), Is.EqualTo(new List<string> { "" }));
    }
    
    [Test]
    public void decode_when_get_empty_list()
    {
        var input = "3#0|0#||";
        Assert.That(Decode(input), Is.EqualTo(new List<string> { "", "" }));
    }
    
    [Test]
    public void decode_when_get_only_1_str()
    {
        var input = "1#7#Str!@|#|";
        Assert.That(Decode(input), Is.EqualTo(new List<string> { "Str!@|#" }));
    }
    
    [Test]
    public void decode_when_get_1_str_list()
    {
        var input = "4#7|12#Str!@|#ThisIsString|";
        Assert.That(Decode(input), Is.EqualTo(new List<string> { "Str!@|#", "ThisIsString"}));
    }
    
    [Test]
    public void encode_when_hello_world()
    {
        var input = new List<string> { "Hello", "World" };
        Assert.That(Encode(input), Is.EqualTo("3#5|5#HelloWorld"));
    }
    
    [Test]
    public void decode_when_hello_world()
    {
        var input = "3#5|5#HelloWorld";
        Assert.That(Decode(input), Is.EqualTo(new List<string> { "Hello", "World" }));
    }
    
    [Test]
    public void encode_when_we_say_yes()
    {
        var input = new List<string> { "we","say",":","yes","!@#$%^&*()" };
        Assert.That(Encode(input), Is.EqualTo("10#2|3|1|3|10#wesay:yes!@#$%^&*()"));
    }
    
    [Test]
    public void decode_when_we_say_yes()
    {
        var input = "10#2|3|1|3|10#wesay:yes!@#$%^&*()";
        var result = Decode(input);
        Assert.That(result, Is.EqualTo(new List<string> { "we","say",":","yes","!@#$%^&*()" }));
    }
    
    List<string> Decode(string s) {
        var result = new List<string>();

        var sizeStr = new StringBuilder();
        
        foreach (var t in s)
        {
            if (t == '#')
            {
                break;
            }
            
            sizeStr.Append(t); 
        }
        
        var startSizeIndex = sizeStr.Length;
        var size = int.Parse(sizeStr.ToString());
        var wordsIndex = startSizeIndex + size + 1 + 1;
        
        for (var i = startSizeIndex + 1; s[i] != '#'; i++)
        {
            var wordSizeStr = new StringBuilder();
            for (var j = i; j < s.Length && s[j] != '#'; j++)
            {
                i = j;
                if (s[j] != '|')
                {
                    wordSizeStr.Append(s[j]);
                    continue;
                }

                break;
            }

            if (wordSizeStr.Length == 0)
            {
                continue;
            }

            var wordSize = int.Parse(wordSizeStr.ToString());
            var word = new StringBuilder();
            for (var j = wordsIndex; j < wordSize + wordsIndex; j++)
            {
                word.Append(s[j]);
            }
            
            wordsIndex += wordSize;
            result.Add(word.ToString());
        }
    
        return result;
    }
    
    string Encode(IList<string> strs) {
        var result = new StringBuilder("#");
        var strSize = new StringBuilder();
    
        foreach (var str in strs)
        {
            result.Append($"{str}");
            strSize.Append($"|{str.Length}");
        }
        
        var trimmedStrSize = strSize.ToString().TrimStart('|');
    
        return result.Insert(0, trimmedStrSize).Insert(0, $"{trimmedStrSize.Length}#").ToString();
    }

}