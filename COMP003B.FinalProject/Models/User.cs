using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class User
    {
        
        public int UserId { get; set; }


        [Required]
        public string UserName { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        // Collection navigation property
        public virtual ICollection<FitnessGoal>? FitnessGoals { get; set; }

        public virtual ICollection<Session>? Sessions { get; set; }
    }
}
