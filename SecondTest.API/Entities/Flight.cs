using System.ComponentModel.DataAnnotations;

namespace SecondTest.API.Entities
{
    public class Flight
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdDepartureAirport { get; set; }
        public int IdArrivalAirport { get; set; }
    }
}
