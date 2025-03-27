using Linq.Mastery.Series.Data.Models;
using Microsoft.Data.SqlClient;

namespace Linq.Mastery.Series.Cmd.NonLinq;

public class NonLinqSamples
{
    public void Run()
    {
        // Working with in-memory objects
        var objectsResult = new List<Book>();

        var bookObjects = GetBooks();

        foreach (var book in bookObjects)
        {
            if (book.Title.Contains("Agile"))
            {
                objectsResult.Add(book);
            }
        }

        // Working with SQL databases
        var sqlResult = new List<Book>();

        var connection = new SqlConnection(GetConnectionString());
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = """
                              SELECT Id, Name, PublishDate
                              FROM dbo.Books
                              WHERE Title LIKE '%Agile%'
                              """;

        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            sqlResult.Add(new Book
            {
                BookId = (Guid)reader["Id"],
                Title = (string)reader["Name"],
                PublishDate = (DateOnly)reader["PublishDate"]
            });
        }

        // Working with LINQ
        var books = GetBooks();

        var linqQueryResult =
                from book in books
                where book.Title.Contains("Agile")
                select book;

        var linqFluentResult = books
            .Where(book => book.Title.Contains("Agile"))
            .Select(book => book);

        // Just to make the code highlighting look OK, and the results are used
        Console.WriteLine(objectsResult.Count);
        Console.WriteLine(sqlResult.Count);
        Console.WriteLine(linqQueryResult.Count());
        Console.WriteLine(linqFluentResult.Count());
    }
    List<Book> GetBooks()
    {
        return new List<Book>();
    }
    string GetConnectionString()
    {
        return string.Empty;
    }
}
