using Microsoft.EntityFrameworkCore;
using proiatest.Entites;

namespace proiatest.DAL
{
    public class ProniaDbContext:DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
