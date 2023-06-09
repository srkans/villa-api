using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaAPI.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required(ErrorMessage = "Name can't be blank")]
        [MaxLength(30,ErrorMessage = "No more than 30 characters")]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}
