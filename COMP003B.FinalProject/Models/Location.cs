using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public int SessionId { get; set; }

        public string LocationName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
