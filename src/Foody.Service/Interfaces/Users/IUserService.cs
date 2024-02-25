using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<UserForResultDto> ModifyAsync(UserForUpdateDto dto);
        Task<UserForResultDto> RetrieveById(long id);
        Task<IEnumerable<UserForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
