using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreExample.Data
{
    public class CoreExampleDbContext : DbContext
    {
        public CoreExampleDbContext(DbContextOptions<CoreExampleDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
