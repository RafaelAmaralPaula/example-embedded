using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TestEntityEmbbeded.Model;

namespace TestEntityEmbbeded.Data
{
    public class DbContextMySql : DbContext
    {

        public DbContextMySql(DbContextOptions<DbContextMySql> options) : base(options) { }


        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}