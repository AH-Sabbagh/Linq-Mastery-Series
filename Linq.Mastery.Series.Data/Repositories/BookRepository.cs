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

        #region Data
        private readonly List<Book> _phaselBooks = [
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                PublishDate = new DateOnly(2008, 8, 11),
                Edition = 1,
                Authors = new List<Person> { new Person("Robert C. Martin", "Author") },
                Editors = new List<Person> { new Person("Prentice Hall", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Pragmatic Programmer: Your Journey to Mastery",
                PublishDate = new DateOnly(1999, 10, 20),
                Edition = 1,
                Authors = new List<Person>
                {
                    new Person("Andrew Hunt", "Author"),
                    new Person("David Thomas", "Author")
                },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                PublishDate = new DateOnly(1994, 10, 21),
                Edition = 1,
                Authors = new List<Person>
                {
                    new Person("Erich Gamma", "Author"),
                    new Person("Richard Helm", "Author"),
                    new Person("Ralph Johnson", "Author"),
                    new Person("John Vlissides", "Author")
                },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Refactoring: Improving the Design of Existing Code",
                PublishDate = new DateOnly(1999, 7, 23),
                Edition = 1,
                Authors = new List<Person> { new Person("Martin Fowler", "Author") },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Mythical Man-Month: Essays on Software Engineering",
                PublishDate = new DateOnly(1975, 10, 1),
                Edition = 1,
                Authors = new List<Person> { new Person("Frederick P. Brooks", "Author") },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Code Complete: A Practical Handbook of Software Construction",
                PublishDate = new DateOnly(1993, 6, 9),
                Edition = 1,
                Authors = new List<Person> { new Person("Steve McConnell", "Author") },
                Editors = new List<Person> { new Person("Microsoft Press", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Structure and Interpretation of Computer Programs",
                PublishDate = new DateOnly(1985, 1, 1),
                Edition = 1,
                Authors = new List<Person>
                {
                    new Person("Harold Abelson", "Author"),
                    new Person("Gerald Jay Sussman", "Author")
                },
                Editors = new List<Person> { new Person("MIT Press", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Patterns of Enterprise Application Architecture",
                PublishDate = new DateOnly(2002, 11, 15),
                Edition = 1,
                Authors = new List<Person> { new Person("Martin Fowler", "Author") },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "You Don't Know JS (book series)",
                PublishDate = new DateOnly(2014, 1, 1),
                Edition = 1,
                Authors = new List<Person> { new Person("Kyle Simpson", "Author") },
                Editors = new List<Person> { new Person("O'Reilly Media", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Working Effectively with Legacy Code",
                PublishDate = new DateOnly(2004, 5, 7),
                Edition = 1,
                Authors = new List<Person> { new Person("Michael Feathers", "Author") },
                Editors = new List<Person> { new Person("Prentice Hall", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation",
                PublishDate = new DateOnly(2010, 10, 15),
                Edition = 1,
                Authors = new List<Person>
                {
                    new Person("Jez Humble", "Author"),
                    new Person("David Farley", "Author")
                },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "The Clean Coder: A Code of Conduct for Professional Programmers",
                PublishDate = new DateOnly(2011, 5, 13),
                Edition = 1,
                Authors = new List<Person> { new Person("Robert C. Martin", "Author") },
                Editors = new List<Person> { new Person("Prentice Hall", "Editor") }
            },
            new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Test-Driven Development: By Example",
                PublishDate = new DateOnly(2002, 7, 2),
                Edition = 1,
                Authors = new List<Person> { new Person("Kent Beck", "Author") },
                Editors = new List<Person> { new Person("Addison-Wesley", "Editor") }
            }
        ];
        #endregion
    }
}
