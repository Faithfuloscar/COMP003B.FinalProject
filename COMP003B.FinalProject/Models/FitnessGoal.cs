using System.ComponentModel.DataAnnotations;
namespace COMP003B.FinalProject.Models
{
    public class FitnessGoal
    {
       
        public int FitnessGoalId { get; set; }

        public int UserId { get; set; }
        [Required]
        public string GoalType { get; set; }

        public virtual User? User { get; set; }
    }
}
