using Linq.Mastery.Series.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Mastery.Series.Data.Repositories
{
    public class BookRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            List<Book> books = [];
            books.AddRange(_phaselBooks);

            return books;
        }

        #region Data
        private readonly List<Book> _phaselBooks = [
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Great Gatsby",
                PublishDate = new DateOnly(1925, 4, 10),
                Edition = 1,
                Authors = new List<Person> { new("F. Scott Fitzgerald", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "1984",
                PublishDate = new DateOnly(1949, 6, 8),
                Edition = 1,
                Authors = new List<Person> { new("George Orwell", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "To Kill a Mockingbird",
                PublishDate = new DateOnly(1960, 7, 11),
                Edition = 1,
                Authors = new List<Person> { new("Harper Lee", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Moby-Dick",
                PublishDate = new DateOnly(1851, 10, 18),
                Edition = 1,
                Authors = new List<Person> { new("Herman Melville", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "War and Peace",
                PublishDate = new DateOnly(1869, 1, 1),
                Edition = 1,
                Authors = new List<Person> { new("Leo Tolstoy", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Pride and Prejudice",
                PublishDate = new DateOnly(1813, 1, 28),
                Edition = 1,
                Authors = new List<Person> { new("Jane Austen", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Catcher in the Rye",
                PublishDate = new DateOnly(1951, 7, 16),
                Edition = 1,
                Authors = new List<Person> { new("J.D. Salinger", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Odyssey",
                PublishDate = new DateOnly(-800, 1, 1),
                Edition = 1,
                Authors = new List<Person> { new("Homer", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Hobbit",
                PublishDate = new DateOnly(1937, 9, 21),
                Edition = 1,
                Authors = new List<Person> { new("J.R.R. Tolkien", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Chronicles of Narnia",
                PublishDate = new DateOnly(1950, 10, 16),
                Edition = 1,
                Authors = new List<Person> { new("C.S. Lewis", "Author") }
            }
                   ];

        private readonly List<Book> _phaselTwoBooks = [
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                PublishDate = new DateOnly(2008, 8, 11),
                Edition = 1,
                Authors = new List<Person> { new("Robert C. Martin", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Pragmatic Programmer",
                PublishDate = new DateOnly(1999, 10, 30),
                Edition = 1,
                Authors = new List<Person> { new("Andrew Hunt", "Author"), new("David Thomas", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                PublishDate = new DateOnly(1994, 1, 1),
                Edition = 1,
                Authors = new List<Person> {
                    new("Erich Gamma", "Author"),
                    new("Richard Helm", "Author"),
                    new("Ralph Johnson", "Author"),
                    new("John Vlissides", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Introduction to Algorithms",
                PublishDate = new DateOnly(1989, 9, 1),
                Edition = 3,
                Authors = [
                    new("Thomas H. Cormen", "Author"),
                    new("Charles E. Leiserson", "Author"),
                    new("Ronald L. Rivest", "Author"),
                    new("Clifford Stein", "Author")]
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Refactoring: Improving the Design of Existing Code",
                PublishDate = new DateOnly(1999, 7, 1),
                Edition = 1,
                Authors = new List<Person> { new("Martin Fowler", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "You Don't Know JS: Scope & Closures",
                PublishDate = new DateOnly(2014, 10, 1),
                Edition = 1,
                Authors = new List<Person> { new("Kyle Simpson", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "JavaScript: The Good Parts",
                PublishDate = new DateOnly(2008, 5, 15),
                Edition = 1,
                Authors = new List<Person> { new("Douglas Crockford", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Clean Coder: A Code of Conduct for Professional Programmers",
                PublishDate = new DateOnly(2011, 5, 1),
                Edition = 1,
                Authors = new List<Person> { new("Robert C. Martin", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Code Complete",
                PublishDate = new DateOnly(2004, 6, 9),
                Edition = 2,
                Authors = new List<Person> { new("Steve McConnell", "Author") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Art of Computer Programming",
                PublishDate = new DateOnly(1968, 1, 1),
                Edition = 1,
                Authors = new List<Person> { new("Donald E. Knuth", "Author") }
            }
      ];
        #endregion
    }
}
