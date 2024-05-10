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
    public class DistrictService : IDistrictService
    {
        private readonly IRepository<District> districtRepository;
        private readonly IRepository<Region> regionRepository;
        private readonly IMapper mapper;

        public DistrictService(
            IMapper mapper,
            IRepository<District> districtRepository,
            IRepository<Region> regionRepository)
        {
            this.mapper = mapper;
            this.districtRepository = districtRepository;
            this.regionRepository = regionRepository;
        }

        public async Task<DistrictForResultDto> AddAsync(DistrictForCreationDto dto)
        {
            var district = await districtRepository.SelectAll()
                .Where(d => d.Name == dto.Name)
                .FirstOrDefaultAsync();

            if (district is not null)
                throw new CustomException(400, "District already exist");

            var region = await regionRepository.SelectAll()
                .Where(r => r.Id == dto.RegionId)
                .FirstOrDefaultAsync();

            if (region is null)
                throw new CustomException(404, "Region is not found");

            var mappedDistrict = mapper.Map<District>(dto);
            var result = await districtRepository.InsertAsync(mappedDistrict);

            return mapper.Map<DistrictForResultDto>(result);
        }

        public async Task<DistrictForResultDto> ModifyAsync(long id, DistrictForUpdateDto dto)
        {
            var district = await districtRepository.SelectAll()
                .Where(d => d.Id == id)
                .FirstOrDefaultAsync();

            if (district is null)
                throw new CustomException(404, "District is not found ");

            var region = await regionRepository.SelectAll()
                .Where(r => r.Id == dto.RegionId)
                .FirstOrDefaultAsync();

            if (region is null)
                throw new CustomException(404, "Region is not found");

            var mappedDistrict = mapper.Map<District>(dto);
            mappedDistrict.UpdatedAt = DateTime.UtcNow;
            var result = await districtRepository.UpdateAsync(mappedDistrict);

            return mapper.Map<DistrictForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var district = await districtRepository.SelectAll()
                .Where(d => d.Id == id)
                .FirstOrDefaultAsync();

            if (district is null)
                throw new CustomException(404, "District is not found ");

            return await districtRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DistrictForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var districts = await districtRepository.SelectAll()
                .Include(r => r.Region)
                .AsNoTracking()
                .ToPagedList(@params)
                .ToListAsync();

            return mapper.Map<IEnumerable<DistrictForResultDto>>(districts);
        }

        public async Task<DistrictForResultDto> RetrieveByIdAsync(long id)
        {
            var district = await districtRepository.SelectIdAsync(id);

            if (district is null)
                throw new CustomException(404, "District is not found");

            return mapper.Map<DistrictForResultDto>(district);
        }
    }
}
