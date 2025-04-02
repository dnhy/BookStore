using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders
{
    public class Order : AuditedAggregateRoot<Guid>
    {

        public string CustomerId { get; set; }

        public float TotalPrice { get; set; }

        public int Quantity { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public PaymentType Payment { get; set; }

        public PayStatusType PayStatus { get; set; }

        public string DeliveryAddress { get; set; }

        public string ConsigneeName { get; set; }

        public string ConsigneeTel { get; set; }
    }
}
