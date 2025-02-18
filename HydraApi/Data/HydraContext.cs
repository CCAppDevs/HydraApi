using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HydraApi.Models;

namespace HydraApi.Data
{
    public class HydraContext : DbContext
    {
        public HydraContext (DbContextOptions<HydraContext> options)
            : base(options)
        {
        }

        public DbSet<HydraApi.Models.Event> Event { get; set; } = default!;
        public DbSet<HydraApi.Models.Category> Category { get; set; } = default!;
    }
}
