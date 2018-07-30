using System;
using NexusTravel.AirEngine.BritishAirway.Enums;

namespace NexusTravel.AirEngine.BritishAirway.Models
{
    public class FlightSearchForm
    {
        public TripType TripType { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }
        public FlightClass FlightClass { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfInfant { get; set; }
        public bool IsDirectFlight { get; set; }
        public bool IsDateFlexible { get; set; }

    }
}
