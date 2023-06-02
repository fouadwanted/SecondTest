using System.ComponentModel.DataAnnotations;

namespace SecondTest.DAL.Entities
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
