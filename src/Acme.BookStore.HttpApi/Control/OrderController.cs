using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.Orders;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Acme.BookStore.Control
{
    [RemoteService(Name = "BookStore")]
    [ControllerName("Order")]
    [Route("api/OrderApi")]
    public class OrderController
    {
        private readonly IOrderService _orderService;


        public OrderController(IOrderService OrderService)
        {
            _orderService = OrderService;

        }

        [HttpGet]
        [Route("order/all")]
        public async Task<List<OrderDto>> GetListAsync()
        {
            var res = await _orderService.GetListAsync();

            return res;
        }
    }
}
