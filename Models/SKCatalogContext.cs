using Microsoft.EntityFrameworkCore;

namespace SKCatalog.Models
{
    public class SKCatalogContext : DbContext
    {
        public SKCatalogContext(DbContextOptions<SKCatalogContext> options)
            : base(options)
        { }

        public DbSet<SKClass> SKClasses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SKClass>().HasData(
                new SKClass
                {
                    CourseId = 1,
                    Name = "Internet Programming",
                    Number = "CPSC-8720-02",
                    Department = "Computer Science",
                    Credit = 3,
                    Capacity = 20
                },
                new SKClass
                {
                    CourseId = 2,
                    Name = "Database Systems",
                    Number = "CPSC-6710-01",
                    Department = "Computer Science",
                    Credit = 3,
                    Capacity = 25
                },
                new SKClass
                {
                    CourseId = 3,
                    Name = "Health Data Management",
                    Number = "HINF-6100-01",
                    Department = "Health Informatica",
                    Credit = 3,
                    Capacity = 30
                },
                new SKClass
                {
                    CourseId = 4,
                    Name = "Calculus I",
                    Number = "MATH-2211-01",
                    Department = "Match",
                    Credit = 4,
                    Capacity = 35
                },
                new SKClass
                {
                    CourseId = 5,
                    Name = "Organic Chemistry",
                    Number = "CHEM-3300-02",
                    Department = "Chemistry",
                    Credit = 4,
                    Capacity = 24
                }
            );
        }
    }
}
