using AirportUtility.Contract.IBusiness;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AirportUtility.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AirportController : ControllerBase
    {
        private readonly IAirportManager _airportManager;

        public AirportController(IAirportManager airportManager)
        {
            _airportManager = airportManager;
        }

        [HttpGet]
        [Route("GetDestinations")]
        public IActionResult GetDestinations([Required, StringLength(3, MinimumLength = 3)] string originCode)
        {
            //_logger.LogInformation(originCode);
            var destinations = _airportManager.GetDestinationsByOrigin(originCode.ToUpper());

            if (destinations == null || !destinations.Any())
            {
                // Return a not found response with a 404 status code
                return NotFound("No destinations found for the specified origin code.");
            }

            return Ok(destinations);

        }
    }
}