using SecondTest.API.Data;
using SecondTest.API.Entities;

namespace SecondTest.TEST
{
    public class FlightRepositoryTests
    {
        private readonly FlightRepository _flightRepository;

        public FlightRepositoryTests()
        {
            _flightRepository = new FlightRepository();
        }

        [Fact]
        public void GetAllFlights()
        {
            // Arrange
            var flights = new List<Flight>
        {
            new Flight { Id = 1, Name = "Flight 1", IdDepartureAirport = 1, IdArrivalAirport = 2 },
            new Flight { Id = 2, Name = "Flight 2", IdDepartureAirport = 2, IdArrivalAirport = 1 }
        };
            _flightRepository.AddFlights(flights);

            // Act
            var result = _flightRepository.GetAllFlights();

            // Assert
            Assert.Equal(flights, result);
        }

        [Fact]
        public void DeleteFlight()
        {
            // Arrange
            int Id = 1;

            // Act
            _flightRepository.DeleteFlight(Id);
            var resault = _flightRepository.GetFlight(Id);
            var flights = _flightRepository.GetAllFlights();

            // Assert
            Assert.DoesNotContain(resault, flights);
        }
    }

}