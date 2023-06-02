using SecondTest.API.Entities;

namespace SecondTest.API.Data
{
    public class FlightRepository
    {
        private readonly List<Flight> _flights;

        public FlightRepository()
        {
            _flights = new List<Flight>();
        }
        public Flight GetFlight(int Id)
        {
            return _flights.Single(f=>f.Id == Id);
        }

        public List<Flight> GetAllFlights()
        {
            return _flights;
        }

        public void AddFlight(Flight flight)
        {
            flight.Id = _flights.Count + 1;
            _flights.Add(flight);
        }
        public void AddFlights(List<Flight> flights)
        {
            _flights.AddRange(flights);
        }

        public void DeleteFlight(int flightId)
        {
            var flight = _flights.FirstOrDefault(f => f.Id == flightId);
            if (flight != null)
            {
                _flights.Remove(flight);
            }
        }
        public void UpdateFlight(Flight updatedFlight)
        {
            var flight = _flights.FirstOrDefault(f => f.Id == updatedFlight.Id);
            if (flight != null)
            {
                flight.Name = updatedFlight.Name;
                flight.IdDepartureAirport = updatedFlight.IdDepartureAirport;
                flight.IdArrivalAirport = updatedFlight.IdArrivalAirport;
            }
        }
    }
}
