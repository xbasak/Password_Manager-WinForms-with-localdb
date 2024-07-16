using System.Data.Entity;

namespace PasswordManager
{
    internal class PasswordManagerContext : DbContext
    {
        public PasswordManagerContext() 
        {
            
        }
        public DbSet <Accounts> Accounts { get; set; }
        public DbSet <User> Users { get; set; }
    }
}

