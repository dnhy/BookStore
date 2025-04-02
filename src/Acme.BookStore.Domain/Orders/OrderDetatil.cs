using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders
{
    public class OrderDetatil : AuditedAggregateRoot<Guid>
    {
        public string OrderId { get; set; }
        public string BookId { get; set; }
        public int BooknNum { get; set; }

    }
}
