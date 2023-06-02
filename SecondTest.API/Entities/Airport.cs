using System.ComponentModel.DataAnnotations;

namespace SecondTest.API.Entities
{
    public class Airport
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
