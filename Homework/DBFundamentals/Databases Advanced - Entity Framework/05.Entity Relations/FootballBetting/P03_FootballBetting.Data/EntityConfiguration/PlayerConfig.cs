using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(e => e.PlayerId);

            builder.HasOne(e => e.Position)
                  .WithMany(p => p.Players)
                  .HasForeignKey(e => e.PositionId);

            builder.HasOne(e => e.Team)
                  .WithMany(t => t.Players)
                  .HasForeignKey(e => e.TeamId);
        }
    }
}
