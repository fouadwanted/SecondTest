using Microsoft.AspNetCore.Mvc;
using SecondTest.Service;
using SecondTest.DAL.Entities;

namespace SecondTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly FlightService _flightService;
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger, FlightService flightService)
        {
            _logger = logger;
            _flightService = flightService;
        }
        [HttpGet]
        public IActionResult GetAllFlights()
        {
            var flights = _flightService.GetAllFlights();
            return Ok(flights);
        }

        [HttpPost]
        public IActionResult AddFlight([FromBody] Flight flight)
        {
            _flightService.AddFlight(flight);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFlight(int id)
        {
            _flightService.DeleteFlight(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFlight(int id, [FromBody] Flight updatedFlight)
        {
            updatedFlight.Id = id;
            _flightService.UpdateFlight(updatedFlight);
            return Ok();
        }
    }
}