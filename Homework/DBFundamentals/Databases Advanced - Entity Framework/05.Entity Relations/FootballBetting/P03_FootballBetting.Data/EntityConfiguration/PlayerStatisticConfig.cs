using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class PlayerStatisticConfig : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.HasKey(e => new { e.PlayerId, e.GameId });

            builder.HasOne(e => e.Game)
                   .WithMany(g => g.PlayerStatistics)
                   .HasForeignKey(e => e.GameId);

            builder.HasOne(e => e.Player)
                   .WithMany(p => p.PlayerStatistics)
                   .HasForeignKey(e => e.PlayerId);
        }
    }
}
