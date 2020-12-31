using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneGame.Models
{
    
        public class DBContext : DbContext
        {
            public DBContext()
            {
             
            }
            public DBContext(DbContextOptions<DBContext> options) : base(options)
            {

            }

            public DbSet<Session> Session { get; set; }
            public DbSet<User> User { get; set; }
            public DbSet<Question> Question { get; set; }


        }
    
}
