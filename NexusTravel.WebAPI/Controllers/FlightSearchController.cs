using Microsoft.AspNetCore.Mvc;
using NexusTravel.AirEngine.BritishAirway.Models;
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
        public string Post([FromBody] FlightSearch form)
        {
            return "result";
        }
    }
}