using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaAPI.Models.DTO
{
    public class VillaUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name can't be blank")]
        [MaxLength(30,ErrorMessage = "No more than 30 characters")]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}
