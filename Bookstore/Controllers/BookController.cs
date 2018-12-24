using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;

        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Book);
    }
}
