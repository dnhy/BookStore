using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public  string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime? PublishDate { get; set; }
        public float Price { get; set; }
        public int LeftNum { get; set; }

        //public Book(string Name1, BookType Type, DateTime PublishDate, float Price)
        //{
        //    this.Name = Name;
        //    this.Type = Type;
        //    this.PublishDate = PublishDate;
        //    this.Price = Price;
        //}
    }
}
