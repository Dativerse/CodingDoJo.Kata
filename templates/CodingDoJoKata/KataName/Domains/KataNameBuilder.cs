using System.Text;

namespace KataName.Domains;

public class KataNameBuilder(int size)
{
    private StringBuilder? _lines { get; set; }

    public void Build()
    {
        _lines = new StringBuilder();
        // TODO: Implement your kata logic here
        for (var i = 1; i <= size; i++)
        {
            _lines.AppendLine(i.ToString());
        }
    }

    public string Result()
    {
        return _lines?.ToString().TrimEnd() ?? string.Empty;
    }
}
