namespace COMP003B.FinalProject.Models
{
    public class Record
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int SessionId { get; set; }

        public int FitnessGoalId { get; set; }

        public int TypeId { get; set; }

        public int ExerciseId { get; set; }

        public int LocationId { get; set; }

        // Nullable navigation proeperties
        public virtual User? Users { get; set; }

        public virtual Session? Session { get; set; }

        public virtual Location? Location { get; set; }

        public virtual FitnessGoal? FitnessGoal { get; set; }

        public virtual Exercise? Exercise { get; set; }
    }
}
