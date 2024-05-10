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
    public class CommentService : ICommentService
    {
        public Task<CommentForResultDto> AddAsync(CommentForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<CommentForResultDto> ModifyAsync(long id, CommentForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CommentForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
