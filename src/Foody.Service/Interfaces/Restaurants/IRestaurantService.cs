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
    public interface IRestaurantService
    {
        Task<RestaurantForResultDto> AddAsync(RestaurantForCreationDto dto);
        Task<RestaurantForResultDto> ModifyAsync(RestaurantForUpdateDto dto);
        Task<RestaurantForResultDto> RetrieveById(long id);
        Task<IEnumerable<RestaurantForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
