using Api_almostHacker.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_almostHacker.Infra
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseInMemoryDatabase(databaseName: "DbTest");

        } 
        public DbSet<Records> Records { get; set; }

        public DbSet<User> Users { get; set; }  

    }
}
