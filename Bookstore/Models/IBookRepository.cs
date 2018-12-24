using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    interface IBookRepository
    {
        IQueryable<Book> Book { get; }
    }
}
