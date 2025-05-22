using Microsoft.EntityFrameworkCore;

namespace Slot3_DemoCodeFirst.Models
{
    public class CodeFirstDemoContext : DbContext
    { 
        public CodeFirstDemoContext() 
        {
        }
        public CodeFirstDemoContext(DbContextOptions<CodeFirstDemoContext> options)
            : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        public DbSet<PlayerInstrument> PlayerInstruments { get; set; }

        // Optional nếu dùng InMemoryDatabase cho test/dev
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("MyDB")
                );
        }
    }
}
