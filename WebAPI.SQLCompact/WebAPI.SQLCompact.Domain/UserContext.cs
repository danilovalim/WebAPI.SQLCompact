using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.SQLCompact.Domain
{
    public class UserContext : DbContext
    {
        public DbSet<User> user { get; set; }
    }
}
