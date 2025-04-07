using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.IRepository;
using AutoMapper.Internal.Mappers;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.BookStore.Orders
{

    //[RemoteService(IsEnabled = false)]
    public class OrderService : ApplicationService, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBookRepository _bookRepository;

        public OrderService(IOrderRepository orderRepository, IBookRepository bookRepository)
        {
            _orderRepository = orderRepository;
            _bookRepository = bookRepository;
        }

        public async Task<List<OrderDto>> GetListAsync()
        {
            var list = await _orderRepository.getListAsync();
            float TotalCount = 0f;
            var dtoList = ObjectMapper.Map<List<Order>, List<OrderDto>>(list);
            dtoList.ForEach(d =>
            {
                d.OrderDetatils.ForEach(o =>
                {
                    TotalCount += o.Book.Price * o.BooknNum;
                });
                d.TotalCount = TotalCount;
            });

            return dtoList;
        }

        public async Task<List<OrderDto>> GetListWithDetail()
        {
            var queryableOrder = await _orderRepository.WithDetailsAsync(x => x.OrderDetatils);

            var orders = await AsyncExecuter.ToListAsync(queryableOrder);
            var dtoList = ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);

            return dtoList;
        }

        public async Task<OrderDto> GetOrderByGuid(Guid id)
        {
            var order = await _orderRepository.GetAsync(id);
            await _orderRepository.EnsureCollectionLoadedAsync(order, x => x.OrderDetatils);

            var dto = ObjectMapper.Map<Order, OrderDto>(order);
            return dto;
        }
    }
}
