using Foody.Service.Configurations;
using Foody.Service.DTOs.Users;
using Foody.Service.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Users
{
    public class UserService : IUserService
    {
        public Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
