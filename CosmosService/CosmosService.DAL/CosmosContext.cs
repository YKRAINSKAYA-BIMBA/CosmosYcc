using Microsoft.EntityFrameworkCore;

namespace CosmosService.DAL
{
    public class CosmosContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Fixation> Fixations { get; set; }


        public CosmosContext(DbContextOptions<CosmosContext> options) : base(options)
            => Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Workplace>()
                .HasIndex(u => u.Title)
                .IsUnique();

            builder.HasPostgresEnum<RoleEnum>();
        }
    }
}
