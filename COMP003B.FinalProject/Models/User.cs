using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class User
    {  
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int RegistrationDate { get; set; }

        // Collection navigation property
        public virtual ICollection<Record> Records { get; set;}
    }
}
