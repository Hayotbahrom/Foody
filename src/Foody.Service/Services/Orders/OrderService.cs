using Foody.Service.Configurations;
using Foody.Service.DTOs.Orders;
using Foody.Service.Interfaces.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Orders
{
    public class OrderService : IOrderService
    {
        public Task<OrderForResultDto> AddAsync(OrderForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForResultDto> ModifyAsync(long id, OrderForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
