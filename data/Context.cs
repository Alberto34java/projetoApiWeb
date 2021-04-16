using Microsoft.EntityFrameworkCore;
using Models;

namespace data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Server=DESKTOP-0V20B0M\\SQLEXPRESS; Database=ApiCursoUniversity; User Id=AlbertoDevTeste; Password=asp02");
        }

       
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
       }
    }
}