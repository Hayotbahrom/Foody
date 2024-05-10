using Foody.Service.Configurations;
using Foody.Service.DTOs.Saveds;
using Foody.Service.Interfaces.Saveds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Saveds
{
    public class SavedProductService : ISavedProductService
    {
        public Task<SavedProductForResultDto> AddAsync(SavedProductForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavedProductForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<SavedProductForResultDto> ModifyAsync(long id, SavedProductForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<SavedProductForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
