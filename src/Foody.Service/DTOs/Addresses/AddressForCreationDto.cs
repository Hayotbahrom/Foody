﻿namespace Foody.Service.DTOs.Addresses;

public class AddressForCreationDto
{
    public string Street { get; set; }
    public string Floor { get; set; }
    public string Home { get; set; }
    public string DoorCode { get; set; }
    public long CountryId { get; set; }
    public long RegionId { get; set; }
    public long DistrictId { get; set; }
}
