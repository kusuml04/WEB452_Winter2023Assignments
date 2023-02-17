using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lamps.Models;

namespace Lamps.Data
{
    public class LampsContext : DbContext
    {
        public LampsContext (DbContextOptions<LampsContext> options)
            : base(options)
        {
        }

        public DbSet<Lamps.Models.Lamp> Lamp { get; set; }
    }
}
