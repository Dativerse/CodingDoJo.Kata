using System.Text;

namespace FizzBuzz.Domains;

public class FizzBuzzBuilder(int size)
{
    private StringBuilder? _lines { get; set; }
    
    public void Build()
    {
        _lines = new StringBuilder();
        for (var i = 1; i <= size; i++)
        {
            if (i % 3 == 0)
            {
                _lines.AppendLine("Fizz");
            }
            else
            {
                _lines.AppendLine(i.ToString());
            }
        }
    }

    public string Result()
    {
        return _lines.ToString().TrimEnd();
    }
}