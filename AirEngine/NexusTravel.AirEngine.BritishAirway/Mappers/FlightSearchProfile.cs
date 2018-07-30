using AutoMapper;
using NexusTravel.AirEngine.BritishAirway.Models;

namespace NexusTravel.AirEngine.BritishAirway.Mappers
{
    public class FlightSearchProfile : Profile
    {
        public FlightSearchProfile()
        {
            CreateMap<FlightSearchForm, FlightSearch>()
                .ForMember(dest => dest.FlightClass, opt => opt.MapFrom(src => (int) src.FlightClass));
        }
    }
}
