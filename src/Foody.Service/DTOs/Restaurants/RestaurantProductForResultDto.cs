using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Restaurants
{
    public class RestaurantProductForResultDto
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
