using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Session
    {
        
        public int  SessionId { get; set; }

        public int UsertId { get; set; }

        [Required]
        public int Date {  get; set; }

        public virtual User? User { get; set; }

        public ICollection<Location>? Locations  { get; set;}

        public ICollection<Exercise>? Exercises { get; set; }
    }
}
