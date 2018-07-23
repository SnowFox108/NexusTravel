﻿using System.Collections.Generic;
using NexusTravel.AirEngine.BritishAirway.Enums;
using NexusTravel.AirEngine.BritishAirway.Models;
using NexusTravel.AirEngine.BritishAirway.Models.Common;

namespace NexusTravel.AirEngine.BritishAirway.Builders
{
   public class PreferenceBuilder : IPreferenceBuilder
    {
        public Preference Create(FlightSearch search)
        {
            return new Preference()
            {
                FarePreferences = CreateFarePreference("759"),
                CabinPreferences = CreateCabinPreference(search.FlightClass)
            };
        }

        private FarePreferences CreateFarePreference(string code)
        {
            return new FarePreferences()
            {
                Types = CreatePreferenceType(code)
            };            
        }

        private List<PreferenceType> CreatePreferenceType(string code)
        {
            var types = new List<PreferenceType>();
            types.Add(new PreferenceType()
            {
                Code = code
            });
            return types;
        }

        private CabinPreferences CreateCabinPreference(FlightClass cabinType)
        {
            return new CabinPreferences()
            {
                CabinType = CreateCabinType(((int)cabinType).ToString())
            };
        }
        private CabinType CreateCabinType(string code)
        {
            return new CabinType()
            {
                Code = code
            };
        }

    }
}
