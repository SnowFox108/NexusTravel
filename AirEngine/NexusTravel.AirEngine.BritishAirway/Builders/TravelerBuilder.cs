using System;
using System.Collections.Generic;
using ClientTest.Entities;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
    internal class TravelerBuilder : ITravelerBuilder
    {
        public List<Traveler> Create(FlightSearch search)
        {
            var travelers = new List<Traveler>();
            for (int i = 0; i < search.NumberOfAdults; i++)
            {
                travelers.Add(CreateAdult());
            }
            for (int i = 0; i < search.NumberOfChildren; i++)
            {
                travelers.Add(CreateChild());
            }
            return travelers;
        }

        private Traveler CreateAdult()
        {
            return new Traveler()
            {
                AnonymousTraveler = CreateAnonymousTraveler("ADT", DateTime.Now.AddYears(-30))
            };
        }

        private Traveler CreateChild()
        {
            return new Traveler()
            {
                AnonymousTraveler = CreateAnonymousTraveler("CHD", DateTime.Now.AddYears(-5))
            };
        }
        private AnonymousTraveler CreateAnonymousTraveler(string ptc, DateTime birth)
        {
            return new AnonymousTraveler()
            {
                PTC = ptc,
                Age = CreateAge(birth)
            };
        }

        private Age CreateAge(DateTime birth)
        {
            return new Age()
            {
                BirthDate = birth
            };
        }
    }
}
