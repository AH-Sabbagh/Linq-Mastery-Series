namespace Linq.Mastery.Series.Cmd._2_FilteringAndOrdering;

public class WhereConditions : QueryExecutor
{
    public override void Run()
    {
        SingleCondition_Q();
        // SingleCondition_F();
        // SingleFunctionCondition_Q();
        // SingleFunctionCondition_F();
        // MultipleConditions_Q();
        // MultipleConditions_F();
    }

    /// <summary>
    /// Single condition, query syntax
    /// </summary>
    private void SingleCondition_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            where book.Title.Contains("Agile")
            select book;

        PrintAll(result);
    }

    /// <summary>
    /// Single condition, fluent syntax
    /// </summary>
    private void SingleCondition_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .Where(book => book.Title.Contains("Agile"));

        PrintAll(result);
    }

    /// <summary>
    /// Single condition from a function, query syntax
    /// </summary>
    private void SingleFunctionCondition_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            where IsCSharpBook(book)
            select book;

        PrintAll(result);
    }

    private static bool IsCSharpBook(Book book)
    {
        return book.Title.Contains("CSharp");
    }

    /// <summary>
    /// Single condition from a function, fluent syntax
    /// </summary>
    private void SingleFunctionCondition_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .Where(IsAgileBook);

        PrintAll(result);
    }

    private static bool IsAgileBook(Book book)
    {
        return book.Title.Contains("Agile");
    }

    /// <summary>
    /// Multiple chained conditions, query syntax
    /// </summary>
    private void MultipleConditions_Q()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result =
            from book in sourceBooks
            where book.Title.Contains("Agile")
            where book.PublishDate.Year < 2020
            select book;

        PrintAll(result);
    }

    /// <summary>
    /// Multiple chained conditions, fluent syntax
    /// </summary>
    private void MultipleConditions_F()
    {
        var sourceBooks = Repository.GetAllBooks();

        var result = sourceBooks
            .Where(book => book.Title.Contains("Agile"))
            .Where(book => book.PublishDate.Year <= 2010);

        PrintAll(result);
    }
}
