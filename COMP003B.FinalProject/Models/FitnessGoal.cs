using System.ComponentModel.DataAnnotations;
namespace COMP003B.FinalProject.Models
{
    public class FitnessGoal
    {
        
        public int FitnessGoalId { get; set; }

        public int UserId { get; set; }

        public string GoalType { get; set; }

        public int TargetDate { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
