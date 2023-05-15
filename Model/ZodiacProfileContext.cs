using Microsoft.EntityFrameworkCore;

namespace Atv1Astrologia.Model
{
    public class ZodiacProfileContext : DbContext
    {
        public ZodiacProfileContext(DbContextOptions<ZodiacProfileContext>
options) : base(options) { }
        public DbSet<ZodiacProfile> ZodiacProfileItens { get; set; } = null!;
    }
}
