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
    public interface IOrderDetailRepository : IBasicRepository<OrderDetatil, Guid>, IRepository<OrderDetatil, Guid>
    {
        Task<List<OrderDetatil>> GetAllListAsync(string OrderId);
    }
}
