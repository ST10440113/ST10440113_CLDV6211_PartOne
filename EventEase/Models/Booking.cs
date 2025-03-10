using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {

        [Key] public int BookingId { get; set; }

        public int EventId { get; set; }

        public int VenueId { get; set; }

    
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

    }
}

