using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.Orders;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.IRepository
{
    public interface IOrderRepository : IBasicRepository<Order, Guid>, IRepository<Order, Guid>
    {
        Task<List<Order>> getListAsync();
    }
}
