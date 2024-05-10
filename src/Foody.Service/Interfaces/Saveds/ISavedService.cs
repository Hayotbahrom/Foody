using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Saveds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Saveds
{
    public interface ISavedService
    {
        Task<SavedForResultDto> AddAsync(SavedForCreationDto dto);
        Task<SavedForResultDto> ModifyAsync(long id, SavedForUpdatDto dto);
        Task<SavedForResultDto> RetrieveById(long id);
        Task<IEnumerable<SavedForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
