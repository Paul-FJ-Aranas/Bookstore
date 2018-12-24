using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class FakeBookRepository : IBookRepository
    {
        public IQueryable<Book> Book => new List<Book> {
            new Book {Title = "The Idiot", Price = 20},
            new Book {Title = "Don Quioxte", Price = 15},
            new Book {Title = "Grapes of Wrath", Price = 18}
        }.AsQueryable<Book>();
    }
}
