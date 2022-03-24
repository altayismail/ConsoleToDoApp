using ConsoleToDoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleToDoApp.DBOperations
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AppDB");
        }
    }
}
