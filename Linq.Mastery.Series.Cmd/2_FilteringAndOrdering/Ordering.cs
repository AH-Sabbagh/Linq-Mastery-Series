namespace Linq.Mastery.Series.Cmd._2_FilteringAndOrdering;

public class Ordering : QueryExecutor
{
    public override void Run()
    {
        SingleOrderBy_Q();
    }

    /// <summary>
    /// Single order by, query syntax
    /// </summary>
    private void SingleOrderBy_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            orderby book.Title
            select book;

        PrintAll(result);
    }

    /// <summary>
    /// Single order by (descending), query syntax
    /// </summary>
    private void SingleOrderByDescending_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            orderby book.Title descending
            select book;

        PrintAll(result);
    }

    /// <summary>
    /// Single order by, fluent syntax
    /// </summary>
    private void SingleOrderBy_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .OrderBy(book => book.Title);

        PrintAll(result);
    }

    /// <summary>
    /// Single order by (descending), fluent syntax
    /// </summary>
    private void SingleOrderByDescending_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .OrderByDescending(book => book.Title);

        PrintAll(result);
    }

    /// <summary>
    /// Multiple order by, query syntax
    /// </summary>
    private void MultipleOrderBy_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            orderby book.PublishDate.Year descending, book.Title
            select book;

        PrintAll(result);
    }

    /// <summary>
    /// Multiple order by, fluent syntax
    /// </summary>
    private void MultipleOrderBy_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .OrderByDescending(book => book.PublishDate.Year)
            .ThenBy(book => book.Title);

        PrintAll(result);
    }

    /// <summary>
    /// Single order by using a custom comparer, fluent syntax
    /// </summary>
    private void OrderByCustomComparer_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .OrderBy(book => book, new BookComparer());

        PrintAll(result);
    }
}
