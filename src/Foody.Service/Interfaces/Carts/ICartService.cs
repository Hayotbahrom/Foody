using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Carts
{
    public interface ICartService
    {
        Task<CartForResultDto> AddAsync(CartForCreationDto dto);
        Task<CartForResultDto> ModifyAsync(long id, CartForUpdateDto dto);
        Task<CartForResultDto> RetrieveById(long id);
        Task<IEnumerable<CartForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
