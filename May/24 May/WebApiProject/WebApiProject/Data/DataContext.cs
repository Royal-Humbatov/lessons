using Microsoft.EntityFrameworkCore;

namespace WebApiProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0EBLJO1\\SQLEXPRESS;Initial Catalog =test;Integrated security=sspi");
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
