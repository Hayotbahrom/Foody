using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses;

public interface ICountryService
{
    Task<bool> RemoveAsync(long id);
    Task<CountryForResultDto> AddAsync(CountryForCreationDto dto);
    Task<CountryForResultDto> ModifyAsync(long id, CountryForUpdateDto dto);
    Task<CountryForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<CountryForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
