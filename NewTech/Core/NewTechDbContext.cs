using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewTech.Core.Model;

namespace NewTech.Core
{
    public class NewTechDbContext : DbContext
    {
        public NewTechDbContext(DbContextOptions<NewTechDbContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
    }
}
