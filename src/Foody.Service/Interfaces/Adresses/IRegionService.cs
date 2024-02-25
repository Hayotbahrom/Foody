using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses;

public interface IRegionService
{
    Task<bool> SetAsync();
    Task<RegionForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<RegionForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
