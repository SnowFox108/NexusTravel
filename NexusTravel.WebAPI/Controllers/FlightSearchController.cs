using Microsoft.AspNetCore.Mvc;
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