using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.IRepository
{
    public interface IBookRepository : IBasicRepository<Book, Guid>, IRepository<Book, Guid>
    {
        Task<List<Book>> getListMoreThanPrice(float price);
    }
}
