﻿using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Location
    {
        
        public int LocationId { get; set; }

        public int SessionId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public virtual ICollection<Record> Records { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
