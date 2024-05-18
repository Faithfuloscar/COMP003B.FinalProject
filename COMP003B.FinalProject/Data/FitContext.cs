using COMP003B.FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.FinalProject.Data
{
    public class FitContext : DbContext
    {
        public FitContext(DbContextOptions<FitContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<FitnessGoal> FitnessGoals { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Record> Records { get; set; }
    }
}
