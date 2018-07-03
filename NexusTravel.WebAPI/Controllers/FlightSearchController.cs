using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusTravel.Dal.Enums;
using NexusTravel.Dal.Models;

namespace NexusTravel.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/FlightSearch")]
    public class FlightSearchController : Controller
    {
        public FlightSearchController()
        {
            
        }

        [HttpPost]
        public string Post([FromBody] FlightSearchForm form)
        {
            return "result";
        }
    }
}