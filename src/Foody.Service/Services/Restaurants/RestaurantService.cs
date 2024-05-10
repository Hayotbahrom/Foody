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
    public class RestaurantService : IRestaurantService
    {
        public Task<RestaurantForResultDto> AddAsync(RestaurantForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RestaurantForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantForResultDto> ModifyAsync(long id, RestaurantForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
