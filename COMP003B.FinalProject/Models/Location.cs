using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Location
    {
        
        public int LocationId { get; set; }

        public int SessionId { get; set; }

        [Required]
        public string LocationName { get; set; }

        public virtual Session? Session { get; set; }

    }
}
