namespace Linq.Mastery.Series.Data.Models;
public class Book
{
    public required Guid BookId { get; init; }
    public required string Title { get; init; }
    public required DateOnly PublishDate { get; init; }
    public int Edition { get; init; }
    public List<Person> Authors { get; set; } = new List<Person>();

    public override string ToString()
    {
        return $"[{BookId}] {Title} ({PublishDate.Year}) - {string.Join(", ", Authors)}";
    }
}
