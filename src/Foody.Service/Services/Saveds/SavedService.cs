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
    public class SavedService : ISavedService
    {
        public Task<SavedForResultDto> AddAsync(SavedForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavedForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<SavedForResultDto> ModifyAsync(long id, SavedForUpdatDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<SavedForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
