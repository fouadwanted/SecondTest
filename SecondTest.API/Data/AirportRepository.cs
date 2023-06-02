using SecondTest.API.Entities;

namespace SecondTest.API.Data
{
    public class AirportRepository
    {
        private readonly List<Airport> _airports;

        public AirportRepository()
        {
            _airports = new List<Airport>();
        }

        public List<Airport> GetAllAirport()
        {
            return _airports;
        }

        public void AddAirport(Airport airport)
        {
            airport.Id = _airports.Count + 1;
            _airports.Add(airport);
        }

        public void DeleteAirport(int airportId)
        {
            var airport = _airports.FirstOrDefault(f => f.Id == airportId);
            if (airport != null)
            {
                _airports.Remove(airport);
            }
        }
        public void UpdateAirport(Airport updateAirport)
        {
            var airport = _airports.FirstOrDefault(f => f.Id == updateAirport.Id);
            if (airport != null)
            {
                airport.Name = updateAirport.Name;
                airport.Id = updateAirport.Id;
                airport.Longitude = updateAirport.Longitude;
                airport.Latitude = updateAirport.Latitude;
            }
        }
    }
}
