using AutoMapper;
using Foody.Data.IRepositories;
using Foody.Domain.Entities.Addresses;
using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;
using Foody.Service.Exceptions;
using Foody.Service.Extentions;
using Foody.Service.Interfaces.Adresses;
using Microsoft.EntityFrameworkCore;

namespace Foody.Service.Services.Addresses
{
    public class CountryService : ICountryService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Country> repository;

        public CountryService(IMapper mapper, IRepository<Country> repository)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CountryForResultDto> AddAsync(CountryForCreationDto dto)
        {
            var country = await repository.SelectAll()
                .Where(c => c.CountryCode == dto.CountryCode)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (country is not null)
                throw new CustomException(409, "Country is already exist");

            var mappedCountry = mapper.Map<Country>(dto);
            var result = await repository.InsertAsync(mappedCountry);

            return mapper.Map<CountryForResultDto>(result);
        }

        public async Task<CountryForResultDto> ModifyAsync(long id, CountryForUpdateDto dto)
        {
            var country = await repository.SelectAll()
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
            if (country == null)
                throw new CustomException(404, "Country is not found");

            var mappedCountry = mapper.Map<Country>(dto);
            mappedCountry.UpdatedAt = DateTime.UtcNow;

            var result = repository.UpdateAsync(mappedCountry);

            return mapper.Map<CountryForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var country = await repository.SelectAll()
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
            if (country == null)
                throw new CustomException(404, "Country is not found");

            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CountryForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var countries = await repository.SelectAll()
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

            return mapper.Map<IEnumerable<CountryForResultDto>>(countries);
        }

        public async Task<CountryForResultDto> RetrieveByIdAsync(long id)
        {
            var country = await repository.SelectAll()
                .Where(c => c.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (country == null)
                throw new CustomException(404, "Country is not found");

            return mapper.Map<CountryForResultDto>(country);
        }
    }
}
