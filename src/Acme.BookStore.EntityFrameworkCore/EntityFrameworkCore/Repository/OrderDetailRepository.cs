﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acme.BookStore.IRepository;
using Acme.BookStore.Orders;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore.Repository
{
    public class OrderDetailRepository : EfCoreRepository<BookStoreDbContext, OrderDetatil, Guid>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<OrderDetatil>> GetAllListAsync(string OrderId)
        {
            return await (await GetDbSetAsync()).ToListAsync();
        }

    }
}
