using System.ComponentModel.DataAnnotations;

namespace KabloomLocationsApi.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        [Required]
        [StringLength(30)]
        public string LocationName { get; set; }
        [Required]
        public string Description { get; set; }

    }
}