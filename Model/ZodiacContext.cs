using Microsoft.EntityFrameworkCore;

namespace Atv1Astrologia.Model
{
    public class ZodiacContext : DbContext
    {
        public ZodiacContext(DbContextOptions<ZodiacContext>
options) : base(options) { }
        public DbSet<Zodiac> CriptoCoinItens { get; set; } = null!;
    }
}
