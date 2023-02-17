

using Microsoft.EntityFrameworkCore;
using Lamps.Models;

namespace Lamps.Data
{
    public class LampContext : DbContext
    {
        public LampContext(DbContextOptions<LampContext> options)
            : base(options)
        {
        }

        public DbSet<Lamp> Lamp { get; set; }
    }
}