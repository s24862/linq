using Microsoft.EntityFrameworkCore;
using Zaj10.Entities.Configs;

namespace Zaj10.Entities
{
    public class UniversityDbContext : DbContext
    {

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Group> Groups { get; set; }


        public UniversityDbContext() 
        { 
        }

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) :base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentEFConfiguration).Assembly);
        }
    }
}
