using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Session
    {
        
        public int  SessionId { get; set; }

        public int UserId { get; set; }

        public int LocationId { get; set; }

        [Required]
        public int Date {  get; set; }

        public int Duration { get; set; }

        public virtual ICollection<Record> Records {  get; set; }
    }
}
