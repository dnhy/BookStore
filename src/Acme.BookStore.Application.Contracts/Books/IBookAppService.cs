using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using Volo.Abp.Application.Services;
namespace Acme.BookStore.Books
{
    //public interface IBookAppService :
    //    ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>;
    public interface IBookAppService : IApplicationService
    {
        Task<BookDto> GetAsync(Guid id);
        Task<List<BookDto>> GetListMoreThanPrice(float price);

    }
}
