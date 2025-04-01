using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.IRepository;
using AutoMapper.Internal.Mappers;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    //public class BookAppService :
    //    CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
    //{
    //    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    //    { }
    //}
    [RemoteService(IsEnabled = false)]
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookRepository _bookRespository;
        public BookAppService(IBookRepository bookRespository)
        {
            _bookRespository = bookRespository;
        }

        public async Task<BookDto> GetAsync(Guid id)
        {
            var entity = await _bookRespository.GetAsync(id);

            var dto = ObjectMapper.Map<Book, BookDto>(entity);

            return dto;

        }

        public async Task<List<BookDto>> GetListMoreThanPrice(float price)
        {
            var list = await _bookRespository.getListMoreThanPrice(price);

            var dtoList = ObjectMapper.Map<List<Book>, List<BookDto>>(list);

            return dtoList;
        }
    }
}
