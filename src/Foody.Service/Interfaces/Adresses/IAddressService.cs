using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses
{
    public interface IAddressService
    {
        Task<AddressForResultDto> AddAsync(AddressForCreationDto address);
        Task<AddressForResultDto> ModifyAsync(AddressForUpdateDto address);
        Task<bool> RemoveAsync(long id);
        Task<AddressForResultDto> RetrieveByIdAsync( long id);
        Task<IEnumerable<AddressForResultDto>> RetrieveAllAsync();
        Task<IEnumerable<AddressForResultDto>> RetrieveAllAsync(PaginationParams @params);
    }
}
