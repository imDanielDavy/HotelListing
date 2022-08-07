
using HotelListing.API.Core.Models;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }
}
