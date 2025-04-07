using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders
{
    public class OrderDetatil : AuditedAggregateRoot<Guid>
    {
        public Guid OrderId { get; set; }

        //循环引用
        //[JsonIgnore]
        public Order Order { get; set; }

        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public int BooknNum { get; set; }

    }
}
