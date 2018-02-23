using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace Sayvin.Models
{
    public class HotelModel
    {
        [Key]
        public int Id { get; set; }

        public string HotelName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DbGeography Location { get; set; }
    }
}
