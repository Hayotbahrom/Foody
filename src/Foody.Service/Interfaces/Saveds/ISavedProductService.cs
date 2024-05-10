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
    public interface ISavedProductService
    {
        Task<SavedProductForResultDto> AddAsync(SavedProductForCreationDto dto);
        Task<SavedProductForResultDto> ModifyAsync(long id, SavedProductForUpdateDto dto);
        Task<SavedProductForResultDto> RetrieveById(long id);
        Task<IEnumerable<SavedProductForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
