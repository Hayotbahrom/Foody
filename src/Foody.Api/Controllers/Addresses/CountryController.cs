using Foody.Api.Models;
using Foody.Service.Configurations;
using Foody.Service.DTOs.Addresses;
using Foody.Service.Interfaces.Adresses;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Api.Controllers.Addresses;
public class CountryController : BaseController
{

    private  readonly ICountryService countryService;
    public CountryController(ICountryService countryService)
    {
        this.countryService = countryService;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddAsync([FromForm]CountryForCreationDto country)
            => Ok(await countryService.AddAsync(country));
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync( [FromRoute(Name = "id")] long id, [FromForm] CountryForUpdateDto country)
        => Ok(await countryService.ModifyAsync(id, country));
    
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        =>Ok(await countryService.RemoveAsync(id));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "id")]long id)
        =>Ok(new Response
        {
            Data = await countryService.RetrieveByIdAsync(id)
        });
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok(new Response
        {
            StatusCode = 200,
            Message = "Success",
            Data = await countryService.RetrieveAllAsync(@params)
        });
    }

}
