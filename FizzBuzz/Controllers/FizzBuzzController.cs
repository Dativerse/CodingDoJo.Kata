using System.Text;

namespace FizzBuzz.Controllers;

public class FizzBuzzController
{
    public string Index(int size)
    {
        var result = new StringBuilder();
        for (var i = 1; i <= size; i++)
        {
            if (i % 3 == 0)
            {
                result.AppendLine("Fizz");
            }
            else
            {
                result.AppendLine(i.ToString());
            }
        }
        return result.ToString().TrimEnd();
    }
}