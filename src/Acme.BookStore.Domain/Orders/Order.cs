using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {

        public Guid CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public PaymentType Payment { get; set; }
        public PayStatusType PayStatus { get; set; }
        [MaxLength(50)]
        public string? DeliveryAddress { get; set; }
        [MaxLength(50)]
        public string? ConsigneeName { get; set; }
        [MaxLength(50)]
        public string? ConsigneeTel { get; set; }

        public ICollection<OrderDetatil> OrderDetatils { get; set; }

        public Order()
        {
            OrderDetatils = new Collection<OrderDetatil>();
        }
    }
}
