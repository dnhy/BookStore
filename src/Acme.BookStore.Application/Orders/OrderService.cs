using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.IRepository;
using AutoMapper.Internal.Mappers;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Orders
{

    [RemoteService(IsEnabled = false)]
    public class OrderService : ApplicationService, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
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
    }
}
