using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    //public class BookAppService :
    //    CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
    //{
    //    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    //    { }
    //}

    public class BookAppService : IBookAppService
    {
        private readonly IBookRepository _bookRespository;
        public BookAppService(IBookRepository bookRespository) {
            _bookRespository = bookRespository;
        }
        public Task<BookDto> GetAsync(Guid id)
        {

        }
    }
}
