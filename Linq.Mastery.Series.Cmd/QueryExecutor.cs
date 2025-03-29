namespace Linq.Mastery.Series.Cmd;

public abstract class QueryExecutor
{
    protected readonly BookRepository Repository = new();

    public abstract void Run();

    protected void Print<T>(T objectToPrint)
    {
        Console.WriteLine(objectToPrint);
    }

    protected void PrintAll<T>(IEnumerable<T> objectsToPrint)
    {
        foreach (var objectToPrint in objectsToPrint)
        {
            Console.WriteLine(objectToPrint);
        }
    }
}
