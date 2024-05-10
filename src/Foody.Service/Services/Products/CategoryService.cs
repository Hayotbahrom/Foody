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
    public class CategoryService : ICategoryService
    {
        public Task<CategoryForResultDto> AddAsync(CategoryForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryForResultDto> ModifyAsync(long id, CategoryForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
