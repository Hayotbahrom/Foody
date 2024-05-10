using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses;

public interface IRegionService
{
    Task<bool> RemoveAsync(long id);
    Task<RegionForResultDto> AddAsync(RegionForCreationDto dto);
    Task<RegionForResultDto> ModifyAsync(long id, RegionForUpdateDto dto);
    Task<RegionForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<RegionForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
