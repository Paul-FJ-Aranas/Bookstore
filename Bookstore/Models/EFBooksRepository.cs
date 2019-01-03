using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBooksRepository : IBookRepository
    {
        private ApplicationDBContext context;

        public EFBooksRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }

        IQueryable<Book> IBookRepository.Book => context.Books;
    }
}
