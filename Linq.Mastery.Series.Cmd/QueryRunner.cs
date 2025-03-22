using Linq.Mastery.Series.Data.Repositories;

namespace Linq.Mastery.Series.Cmd;

public abstract class QueryRunner
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
