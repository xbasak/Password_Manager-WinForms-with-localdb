//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace PasswordManager
{
    internal class PasswordManagerContext : DbContext
    {
        public PasswordManagerContext() 
        {
            
        }
        public DbSet <Accounts> Accounts { get; set; }
        public DbSet <User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "PasswordManagerDB.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
    }
}

