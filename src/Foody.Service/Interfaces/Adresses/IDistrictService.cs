using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses
{
    public interface IDistrictService
    {
        Task<bool> SetAsync();
        Task<DistrictForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<DistrictForResultDto>> RetrieveAllAsync(PaginationParams @params);
    }
}
