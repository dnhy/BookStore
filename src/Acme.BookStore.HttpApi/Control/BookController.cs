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
    [ControllerName("Book")]
    [Route("api/BooksApi")]
    public class BookController : BookStoreController
    {
        readonly IBookAppService _entityAppService;

        public BookController(IBookAppService input)
        {
            _entityAppService = input;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BookDto> GetAsync(Guid id)
        {
            Console.WriteLine("id:{0}", id);
            return await _entityAppService.GetAsync(id);
        }

        [HttpGet]
        [Route("{price}")]
        public async Task<List<BookDto>> getListMoreThanPrice(float price)
        {
            return await _entityAppService.GetListMoreThanPrice(price);
        }
    }
}
