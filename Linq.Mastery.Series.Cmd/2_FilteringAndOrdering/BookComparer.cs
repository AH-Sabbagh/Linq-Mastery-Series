
namespace Linq.Mastery.Series.Cmd._2_FilteringAndOrdering
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            // Same instance
            if (ReferenceEquals(x, y)) return 0;

            // Null is smaller than everything
            if (x is null) return -1;
            if (y is null) return 1;

            // If the years are different, sort by year
            if (x.PublishDate.Year < y.PublishDate.Year)
                return -1;
            if (x.PublishDate.Year > y.PublishDate.Year)
                return 1;

            // If the years are equal, sort by name
            return string.Compare(x.Title, y.Title, StringComparison.Ordinal);
        }
    }
}
