using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses;

public interface ICountryService
{
    Task<bool> SetAsync();
    Task<CountryForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<CountryForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
