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
        public DbSet<FitnessGoal> FitnessGoal { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
