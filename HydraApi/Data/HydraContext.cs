using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.EntityFrameworkCore;

namespace HydraApi.Data
{
    public class HydraContext : DbContext
    {
        public HydraContext (DbContextOptions<HydraContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
    }
}
