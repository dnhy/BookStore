using Acme.BookStore.Books;

namespace Acme.BookStore.Orders
{
    public class BooksInOrderDto : BookDto
    {
        public int PurchaseQuantity;
    }
}
