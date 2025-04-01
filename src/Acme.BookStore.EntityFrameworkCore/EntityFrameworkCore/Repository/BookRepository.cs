using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.IRepository;

namespace Acme.BookStore.EntityFrameworkCore.Repository
{
    public class BookRepository : EfCoreRepository<BookStoreDbContext, BookStoreDbContext, Book, Guid>, IBookRepository
    {
    }
}
