namespace Linq.Mastery.Series.Data.Models;

public record Person(string Name, string Role)
{
    public override string ToString()
    {
        return $"{Name} {Role}";
    }
}
