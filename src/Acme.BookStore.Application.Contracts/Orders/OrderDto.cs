using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Orders
{
    public class OrderDto : ExtensibleEntityDto<Guid>
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

        public List<OrderDetailDto> OrderDetatils { get; set; }

        public float TotalCount { get; set; }

    }
}
