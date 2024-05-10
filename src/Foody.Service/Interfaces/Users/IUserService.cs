using Foody.Service.Configurations;
using Foody.Service.DTOs.Users;

namespace Foody.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
        Task<UserForResultDto> RetrieveById(long id);
        Task<IEnumerable<UserForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
