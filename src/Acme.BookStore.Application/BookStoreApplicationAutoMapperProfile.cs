using Acme.BookStore.Books;
using Acme.BookStore.Orders;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>().ReverseMap().MapExtraProperties();
        CreateMap<Order, OrderDto>().ReverseMap().MapExtraProperties();
        CreateMap<Book, CreateUpdateBookDto>().ReverseMap().MapExtraProperties();
        CreateMap<OrderDetatil, OrderDetailDto>().ReverseMap().MapExtraProperties();

    }
}
