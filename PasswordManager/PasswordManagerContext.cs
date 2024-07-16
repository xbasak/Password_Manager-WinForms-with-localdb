using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

