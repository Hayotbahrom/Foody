using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Interfaces.Payments
{
    public interface IPaymentService
    {
        Task<PaymentForResultDto> AddAsync(PaymentForCreationDto dto);
        Task<PaymentForResultDto> ModifyAsync(PaymentForUpdateDto dto);
        Task<PaymentForResultDto> RetrieveById(long id);
        Task<IEnumerable<CartForResultDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RemoveAsync(long id);
    }
}
