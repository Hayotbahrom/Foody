using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Restaurants
{
    public interface IRestaurantProductService
    {
        Task<RestaurantProductForResultDto> AddAsync(RestaurantProductForCreationDto dto);
        Task<RestaurantProductForResultDto> ModifyAsync(long id, RestaurantProductForUpdateDto dto);
        Task<RestaurantProductForResultDto> RetrieveById(long id);
        Task<IEnumerable<RestaurantProductForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
