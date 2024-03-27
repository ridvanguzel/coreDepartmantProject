using Microsoft.EntityFrameworkCore;

namespace coreDepartmantProject.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI\\RIDVAN; database=corepersonel; integrated security=true;");
            //string? constr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["connectionstring"];
            //optionsBuilder.UseSqlServer(constr);
        }
        public DbSet<departmant> departmants { get; set; }
        public DbSet<personal> personals { get; set; }
    }
}
