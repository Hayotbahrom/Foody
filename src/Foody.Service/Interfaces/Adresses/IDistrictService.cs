using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses
{
    public interface IDistrictService
    {
        Task<bool> RemoveAsync(long id);
        Task<DistrictForResultDto> AddAsync(DistrictForCreationDto dto);
        Task<DistrictForResultDto> ModifyAsync(long id, DistrictForUpdateDto dto);
        Task<DistrictForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<DistrictForResultDto>> RetrieveAllAsync(PaginationParams @params);
    }
}
