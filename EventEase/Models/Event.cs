using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {

        
        [Key]
        
        public int EventId { get; set; }

        [Display(Name = "Event Name")] 
        public required string EventName { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        
        

    }
}


