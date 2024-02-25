using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Orders
{
    public interface IOrderService
    {
        Task<OrderForResultDto> AddAsync(OrderForCreationDto dto);
        Task<OrderForResultDto> ModifyAsync(OrderForCreationDto dto);
        Task<OrderForResultDto> RetrieveById(long id);
        Task<IEnumerable<OrderForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
