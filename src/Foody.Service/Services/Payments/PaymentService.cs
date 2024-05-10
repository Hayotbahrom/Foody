using Foody.Service.Configurations;
using Foody.Service.DTOs.Carts;
using Foody.Service.DTOs.Payments;
using Foody.Service.Interfaces.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        public Task<PaymentForResultDto> AddAsync(PaymentForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartForResultDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForResultDto> ModifyAsync(long id, PaymentForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForResultDto> RetrieveById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
