using Microsoft.EntityFrameworkCore;

namespace CoinJar.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

        public DbSet<Coin> Coins { get; set; }
    }
}
