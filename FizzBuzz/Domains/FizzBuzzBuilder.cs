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
            var isDivisibleBy3 = i % 3 == 0;
            var isDivisibleBy5 = i % 5 == 0;

            var isContains3 = i.ToString().Contains('3');
            var isContains5 = i.ToString().Contains('5');
            
            if (isContains3 && isContains5)
            {
                var line = "FizzBuzz";
                if (isDivisibleBy3)
                {
                    line = "Fizz" + line;
                }

                if (isDivisibleBy5)
                {
                    line += "Buzz";
                }
                
                _lines.AppendLine(line);
            }
            else if (isDivisibleBy3 && isDivisibleBy5)
            {
                _lines.AppendLine("FizzBuzz");
            }
            else if (isDivisibleBy3 || isContains3)
            {
                _lines.AppendLine("Fizz");
            }
            else if (isDivisibleBy5 || isContains5)
            {
                _lines.AppendLine("Buzz");
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