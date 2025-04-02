using System;
using System.Threading.Tasks;
using Acme.BookStore.Orders;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor2 : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Order, Guid> _orderRepository;
        private readonly IRepository<OrderDetatil, Guid> _orderRepository2;


        public BookStoreDataSeederContributor2(IRepository<Order, Guid> orderRepository, IRepository<OrderDetatil, Guid> orderRepository2)
        {
            _orderRepository = orderRepository;
            _orderRepository2 = orderRepository2;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _orderRepository.GetCountAsync() <= 0)
            {
                await _orderRepository.InsertAsync(new Order
                {
                    CustomerId = Guid.NewGuid().ToString(),
                    TotalPrice = 12.5f,
                    Quantity = 12,
                    OrderDate = DateTimeOffset.Now,
                    Payment = PaymentType.AliPay,
                    PayStatus = PayStatusType.unpayed,
                }, autoSave: true
);
            }

            if (await _orderRepository2.GetCountAsync() <= 0)
            {
                await _orderRepository2.InsertAsync(new OrderDetatil
                {
                    OrderId = "3a19088e-e11c-6eab-fb52-3fee8380b98b",
                    BookId = "3a190843-37da-3b03-7c55-65f6d6cf387c"
                }, autoSave: true
);
            }
        }
    }
}
