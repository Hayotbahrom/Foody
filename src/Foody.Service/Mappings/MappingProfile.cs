using AutoMapper;
using Foody.Domain.Entities.Addresses;
using Foody.Service.DTOs.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            // Country
            CreateMap<Country, CountryForCreationDto>().ReverseMap();
            CreateMap<Country, CountryForResultDto>().ReverseMap();
            CreateMap<Country, CountryForUpdateDto>().ReverseMap();

        }

    }
}
