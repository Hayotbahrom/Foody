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
    public interface ICommentService
    {
        Task<CommentForResultDto> AddAsync(CommentForCreationDto dto);
        Task<CommentForResultDto> ModifyAsync(CommentForUpdateDto dto);
        Task<CommentForResultDto> RetrieveById(long id);
        Task<IEnumerable<CommentForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
