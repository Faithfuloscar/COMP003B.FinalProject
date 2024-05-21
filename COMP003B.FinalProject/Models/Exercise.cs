using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Exercise
    {
        
        public int ExerciseId { get; set; }

        public int SessionId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Session? Session { get; set; }

    }
}
