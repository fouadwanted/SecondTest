using SecondTest.API.Data;
using SecondTest.API.Entities;

namespace SecondTest.API.Services
{
    public class FlightService
    {
        private readonly FlightRepository _flightRepository;

        public FlightService(FlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        public Flight GetFlight(int Id)
        {
           return _flightRepository.GetFlight(Id);
        }

        public List<Flight> GetAllFlights()
        {
            return _flightRepository.GetAllFlights();
        }

        public void AddFlight(Flight flight)
        {
            _flightRepository.AddFlight(flight);
        }

        public void DeleteFlight(int flightId)
        {
            _flightRepository.DeleteFlight(flightId);
        }

        public void UpdateFlight(Flight updatedFlight)
        {
            _flightRepository.UpdateFlight(updatedFlight);
        }
    }
}
