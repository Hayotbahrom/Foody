using Foody.Data.IRepositories;
using Foody.Data.Repositories;
using Foody.Service.Interfaces.Adresses;
using Foody.Service.Mappings;
using Foody.Service.Services.Addresses;

namespace Foody.Api.Extentions;

public static class ServiceExtention
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // Generic Repository
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        // Country
        services.AddScoped<ICountryService, CountryService>();
        // Address
        services.AddScoped<IAddressService, AddressService>();
        // District
        services.AddScoped<IDistrictService, DistrictService>();
        // Region
        services.AddScoped<IDistrictService, DistrictService>();

        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));
    }
}
