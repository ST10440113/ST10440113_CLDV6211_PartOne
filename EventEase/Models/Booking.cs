using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {

        [Key] public int BookingId { get; set; }


        [Display(Name = "Event ID")] 
        public int EventId { get; set; }

        [Display(Name = "Venue ID")] 
        public int VenueId { get; set; }

    
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

    }
}

