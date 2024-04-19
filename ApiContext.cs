
using AdvisorMangementAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace AdvisorMangementAPI
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb1");
        }
        public DbSet<Author> Authors { get; set; }
    }
}