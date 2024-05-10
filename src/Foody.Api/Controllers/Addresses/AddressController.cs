using Foody.Service.DTOs.Addresses;
using Foody.Service.Interfaces.Adresses;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Api.Controllers.Addresses
{
    public class AddressController : BaseController
    {
        private readonly IAddressService addressService;
        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }

        [HttpPost]
        public async Task<IActionResult>AddAsync([FromForm]AddressForCreationDto address)
            => Ok(await this.addressService.AddAsync(address));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute(Name = "id")]long id, [FromForm]AddressForUpdateDto address)
            => Ok(await this.addressService.ModifyAsync(id,address));
    }
}
