using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.IRepository;
using AutoMapper.Internal.Mappers;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Orders
{
    [RemoteService(IsEnabled = false)]
    public class OrderDetailService : ApplicationService, IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public async Task<List<OrderDetailDto>> GetAllListAsync(RequestOrderInput input)
        {
            var list = await _orderDetailRepository.GetAllListAsync(input.OrderId);
            var dtoList = ObjectMapper.Map<List<OrderDetatil>, List<OrderDetailDto>>(list);

            return dtoList;
        }
    }
}
