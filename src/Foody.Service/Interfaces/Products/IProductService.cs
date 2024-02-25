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
    public interface IProductService
    {
        Task<ProductForResultDto> AddAsync(ProductForCreationDto dto);
        Task<ProductForResultDto> ModifyAsync(ProductForUpdateDto dto);
        Task<ProductForResultDto> RetrieveById(long id);
        Task<IEnumerable<ProductForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
