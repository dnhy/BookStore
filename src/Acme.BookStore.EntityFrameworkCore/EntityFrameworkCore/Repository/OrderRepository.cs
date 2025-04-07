using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.IRepository;
using Acme.BookStore.Orders;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore.Repository
{
    public class OrderRepository : EfCoreRepository<BookStoreDbContext, Order, Guid>, IOrderRepository
    {
        public OrderRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<Order>> getListAsync()
        {
            return await (await GetDbSetAsync()).Include(p => p.OrderDetatils).ThenInclude(q => q.Book).ToListAsync();
        }
    }
}
