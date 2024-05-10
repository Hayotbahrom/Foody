using Foody.Service.Configurations;
using Foody.Service.DTOs.Products;
using Foody.Service.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Products
{
    public class ProductService : IProductService
    {
        public Task<ProductForResultDto> AddAsync(ProductForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<ProductForResultDto> ModifyAsync(long id, ProductForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
