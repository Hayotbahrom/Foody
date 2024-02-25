using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Products
{
    public interface ICategoryService
    {
        Task<CategoryForResultDto> AddAsync(CategoryForCreationDto dto);
        Task<CategoryForResultDto> ModifyAsync(CategoryForUpdateDto dto);
        Task<CategoryForResultDto> RetrieveById(long id);
        Task<IEnumerable<CategoryForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
