using Foody.Service.Configurations;
using Foody.Service.DTOs.Restaurants;
using Foody.Service.Interfaces.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Restaurants
{
    public class RestaurantProductService : IRestaurantProductService
    {
        public Task<RestaurantProductForResultDto> AddAsync(RestaurantProductForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RestaurantProductForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantProductForResultDto> ModifyAsync(long id, RestaurantProductForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantProductForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
