﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Orders
{
    public interface IOrderDetailService : IApplicationService
    {
        Task<List<OrderDetailDto>> GetAllListAsync(RequestOrderInput input);
    }
}
