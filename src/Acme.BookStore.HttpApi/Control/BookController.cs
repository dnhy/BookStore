using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Controllers;
using Asp.Versioning;
using Microsoft.AspNetCore.Components;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Control
{
    [ControllerName("BooksApi")]
    [Route("api/BooksApi")]
    public class BookController: BookStoreController
    {
        public string GetAsync(Guid id)
        {
            Console.WriteLine("id:{0}", id);
            return "111";
        }
    }
}
