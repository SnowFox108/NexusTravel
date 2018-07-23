using System;
using System.Collections.Generic;
using NexusTravel.AirEngine.BritishAirway.Enums;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    public class CoreQueryBuilder : ICoreQueryBuilder
    {
        public CoreQuery Create(FlightSearch search)
        {
            return new CoreQuery()
            {
                OriginDestinations = CreateDestinations(search)
            };
        }

        private List<OriginDestination> CreateDestinations(FlightSearch search)
        {
            var destinations = new List<OriginDestination>();
            switch (search.TripType)
            {
                case TripType.OneWay:
                    destinations.Add(CreateDestination(search.From, search.To, search.Departure));
                    break;
                case TripType.Return:
                    destinations.Add(CreateDestination(search.From, search.To, search.Departure));
                    destinations.Add(CreateDestination(search.To, search.From, search.Return));
                    break;                    
            }
            return destinations;
        }

        private OriginDestination CreateDestination(string departure, string arrival, DateTime date)
        {
            return new OriginDestination()
            {
                Departure = CreateDepature(departure, date),
                Arrival = CreateArrival(arrival)
            };
        }

        private Departure CreateDepature(string airportCode, DateTime date)
        {
            return new Departure()
            {
                AirportCode = airportCode,
                Date = date
            };
        }

        private Arrival CreateArrival(string airportCode)
        {
            return new Arrival()
            {
                AirportCode = airportCode
            };
        }
    }
}
