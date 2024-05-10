using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.Interfaces.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Carts
{
    public class CartSErvice : ICartService
    {
        public Task<CartForResultDto> AddAsync(CartForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<CartForResultDto> ModifyAsync(long id, CartForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CartForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
