using AutoMapper;
using Foody.Data.IRepositories;
using Foody.Domain.Entities.Addresses;
using Foody.Service.DTOs.Addresses;
using Foody.Service.Exceptions;
using Foody.Service.Interfaces.Adresses;
using Microsoft.EntityFrameworkCore;

namespace Foody.Service.Services.Addresses
{
    public class AddressService : IAddressService
    {
        private readonly IRepository<Address> repository;
        private readonly IMapper mapper;

        public async Task<AddressForResultDto> AddAsync(AddressForCreationDto dto)
        {
            var address = await repository.SelectAll()
                .Where(a => a.CountryId == dto.CountryId
                && a.RegionId == dto.RegionId
                && a.DistrictId == dto.DistrictId
                && a.Floor == dto.Floor
                && a.Home == dto.Home)
                //.AsNoTracking()
                .FirstOrDefaultAsync();

            if (address is not null)
                throw new CustomException(409, "Address is already exist");

            var mappedCountry = mapper.Map<Address>(dto);
            var result = await repository.InsertAsync(mappedCountry);

            return mapper.Map<AddressForResultDto>(result);
        }

        public async Task<AddressForResultDto> ModifyAsync(long id, AddressForUpdateDto dto)
        {
            var address = await repository.SelectAll()
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if (address is null)
                throw new CustomException(404, "Address is not found");

            var mappedDto = mapper.Map<Address>(dto);
            mappedDto.UpdatedAt = DateTime.UtcNow;

            return mapper.Map<AddressForResultDto>(await repository.UpdateAsync(mappedDto));
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var address = await repository.SelectAll()
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
            if (address is null)
                throw new CustomException(404, "Address is not found");

            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AddressForResultDto>> RetrieveAllAsync()
        {
            var addresses = await repository.SelectAll()
                .ToListAsync();

            return mapper.Map<IEnumerable<AddressForResultDto>>(addresses);
        }


        public async Task<AddressForResultDto> RetrieveByIdAsync(long id)
        {
            var address = await repository.SelectAll()
                .Where(a => a.Id == id)
                .AsNoTracking().FirstOrDefaultAsync();

            if (address is null)
                throw new CustomException(404, "Address is not found ");

            return mapper.Map<AddressForResultDto>(address);
        }
    }
}
