using Microsoft.EntityFrameworkCore;

namespace coreDepartmantProject.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI\\RIDVAN; database=corepersonel; integrated security=true;");
        }
        public DbSet<departmant> departmants { get; set; }
        public DbSet<personal> personals { get; set; }
    }
}
