using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.IRepository;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Linq;


namespace Acme.BookStore.EntityFrameworkCore.Repository
{
    public class BookRepository : EfCoreRepository<BookStoreDbContext, Book, Guid>, IBookRepository
    {
        public BookRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<Book>> getListMoreThanPrice(float price)
        {
            return await (await GetDbSetAsync()).Where(p => p.Price > price).ToListAsync();
        }
    }
}
