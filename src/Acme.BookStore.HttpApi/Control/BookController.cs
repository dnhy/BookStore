using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.Controllers;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Acme.BookStore.Control
{
    [RemoteService(Name = "BookStore")]
    [ControllerName("Book")]
    [Route("api/BooksApi")]
    public class BookController : BookStoreController
    {
        private readonly IBookAppService _entityAppService;

        public BookController(IBookAppService input)
        {
            _entityAppService = input;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BookDto> GetAsync(Guid id)
        {
            return await _entityAppService.GetAsync(id);
        }

        [HttpGet]
        [Route("priceBT/{price}")]
        public async Task<List<BookDto>> getListMoreThanPrice(float price)
        {
            return await _entityAppService.GetListMoreThanPrice(price);
        }
    }
}
