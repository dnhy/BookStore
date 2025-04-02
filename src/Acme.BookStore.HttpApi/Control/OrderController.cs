using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.Orders;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Control
{
    public class OrderController
    {
        readonly IOrderDetailService _orderDetailService;

        public OrderController(IOrderDetailService OrderDetailService)
        {
            _orderDetailService = OrderDetailService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<OrderDetailDto>> GetAsync(RequestOrderInput input)
        {
            return await _orderDetailService.GetAllListAsync(input);
        }
    }
}
