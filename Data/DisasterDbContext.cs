using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisasterAid.Data
{
    public class DisasterDbContext : IdentityDbContext
    {
        public DisasterDbContext(DbContextOptions<DisasterDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DisasterParticipant>()
                .HasKey(dp => new { dp.DisasterId, dp.HelperId });

            modelBuilder.Entity<DisasterParticipant>()
                .HasOne(dp => dp.Disaster)
                .WithMany(d => d.DisasterParticipants)
                .HasForeignKey(dp => dp.DisasterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DisasterParticipant>()
                .HasOne(dp => dp.Helper)
                .WithMany()
                .HasForeignKey(dp => dp.HelperId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DisasterType>()
                .HasData(
                    new DisasterType { Id = 1, Name = "Earthquake" },
                    new DisasterType { Id = 2, Name = "Flood" },
                    new DisasterType { Id = 3, Name = "Wildfire" },
                    new DisasterType { Id = 4, Name = "Storm" },
                    new DisasterType { Id = 5, Name = "Tsunami" },
                    new DisasterType { Id = 6, Name = "Volcanic Eruption" },
                    new DisasterType { Id = 7, Name = "Drought" },
                    new DisasterType { Id = 8, Name = "Snowstorm" },
                    new DisasterType { Id = 9, Name = "Avalanche" },
                    new DisasterType { Id = 10, Name = "Tornado" },
                    new DisasterType { Id = 11, Name = "Hurricane" },
                    new DisasterType { Id = 12, Name = "Heatwave" },
                    new DisasterType { Id = 13, Name = "Landslide" },
                    new DisasterType { Id = 14, Name = "Ice Flood" }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Disaster> Disasters { get; set; }
        public DbSet<DisasterType> DisasterTypes { get; set; }
        public DbSet<DisasterParticipant> DisasterParticipants { get; set; }
    }
}

