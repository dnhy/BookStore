using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Orders
{
    public class OrderDetailDto : AuditedEntityDto<Guid>
    {
        public string OrderId { get; set; }
        public string BookId { get; set; }
        public int BooknNum { get; set; }
        public List<BooksInOrderDto> BooksInOrder { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
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
    }
}
