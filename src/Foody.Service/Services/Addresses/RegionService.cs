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
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> regionRepository;
        private readonly IRepository<Country> countryRepository;
        private readonly IMapper mapper;

        public RegionService(
            IMapper mapper,
            IRepository<Region> regionRepository,
            IRepository<Country> countryRepository)
        {
            this.mapper = mapper;
            this.regionRepository = regionRepository;
            this.countryRepository = countryRepository;
        }

        public async Task<RegionForResultDto> AddAsync(RegionForCreationDto dto)
        {
            var region = await regionRepository.SelectAll()
                .Where(r => r.Name == dto.Name)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region != null)
                throw new CustomException(400, "Region is already exist");

            var country = await countryRepository.SelectAll()
                .Where(c => c.Id == dto.CountryId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (country == null)
                throw new CustomException(404, "country is not found"); ;

            var mappedRegion = mapper.Map<Region>(dto);
            var result = await regionRepository.InsertAsync(mappedRegion);

            return mapper.Map<RegionForResultDto>(result);
        }

        public async Task<RegionForResultDto> ModifyAsync(long id, RegionForUpdateDto dto)
        {
            var region = await regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new CustomException(400, "Region is not found");

            var country = await countryRepository.SelectAll()
                .Where(c => c.Id == dto.CountryId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (country == null)
                throw new CustomException(404, "country is not found"); ;

            var mappedRegion = mapper.Map<Region>(dto);
            mappedRegion.UpdatedAt = DateTime.UtcNow;

            return mapper.Map<RegionForResultDto>(await regionRepository.UpdateAsync(mappedRegion));
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var region = await regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new CustomException(400, "Region is not found");

            return await regionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<RegionForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var regions = await regionRepository.SelectAll()
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

            return mapper.Map<IEnumerable<RegionForResultDto>>(regions);
        }

        public async Task<RegionForResultDto> RetrieveByIdAsync(long id)
        {
            var region = await regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (region == null)
                throw new CustomException(400, "Region is not found");

            return mapper.Map<RegionForResultDto>(region);
        }
    }
}
