using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Orders
{
    public class OrderDetailDto : ExtensibleAuditedEntityDto<Guid>
    {
        public Guid OrderId { get; set; }

        public OrderDto Order { get; set; }

        public Guid BookId { get; set; }

        public BookDto Book { get; set; }

        public int BooknNum { get; set; }
    }
}
