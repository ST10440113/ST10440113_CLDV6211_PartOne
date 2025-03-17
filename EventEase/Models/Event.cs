using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int EventId { get; set; }
       
        public required string EventName { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        
        

    }
}


