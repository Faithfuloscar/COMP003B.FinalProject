using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }

        public int SessionId { get; set; }

        public string Name { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public int Weight { get; set; }

        public virtual ICollection<Record> Records { get; set; }

    }
}
