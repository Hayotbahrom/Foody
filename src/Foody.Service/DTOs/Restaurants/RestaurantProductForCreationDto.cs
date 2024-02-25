using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Restaurants
{
    public class RestaurantProductForCreationDto
    {
        public long ProductId { get; set; }
        public long RestaurantId { get; set; }
    }
}
