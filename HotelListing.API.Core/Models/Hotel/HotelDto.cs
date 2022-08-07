using HotelListing.API.Core.Models;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDto : BaseHotelDto, IBaseDto
    {
            public int Id { get; set; }
    }
}
