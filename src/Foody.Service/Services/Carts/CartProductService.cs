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
    public class CartProductService : ICartProductService
    {
        public Task<CartProductForResultDto> AddAsync(CartProductForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<CartProductForResultDto> ModifyAsync(long id, CartProductForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CartProductForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
