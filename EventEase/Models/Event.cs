using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {

        [Key] public int EventId { get; set; }
        public required string EventName { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

    }
}


