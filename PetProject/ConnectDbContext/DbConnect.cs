using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.ConnectDbContext
{
    public class DbConnect : DbContext
    {
        public DbConnect() : base("DbConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
