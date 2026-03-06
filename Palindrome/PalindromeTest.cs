namespace Palindrome;

public class PalindromeTest
{
    [Test]
    public void palindrome_when_receive_valid_string()
    {
        var input = "Was it a car or a cat I saw?";
        var expected = true;

        var result = IsPalindrome(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void palindrome_when_receive_valid_string_2()
    {
        var input = "a.";
        var expected = true;

        var result = IsPalindrome(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void palindrome_when_receive_valid_without_characters()
    {
        var input = ".,";
        var expected = true;

        var result = IsPalindrome(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void invalid_palindrome_when_receive_invalid_string()
    {
        var input = "tab a cat";
        var expected = false;

        var result = IsPalindrome(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private bool IsPalindrome(string s)
    {
        var i = 0;
        var j = s.Length - 1;
        var strLength = 0;
        
        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(s[i]))
            {
                i++;
            }

            while (j > i && !char.IsLetterOrDigit(s[j]))
            {
                j--;
            }
            
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }

            i++;
            j--;
            strLength++;
        }

        if (strLength % 2 == 0 || strLength <= 1)
        {
            return true;
        }
        
        return char.ToLower(s[i]) == char.ToLower(s[j]);
    }
}