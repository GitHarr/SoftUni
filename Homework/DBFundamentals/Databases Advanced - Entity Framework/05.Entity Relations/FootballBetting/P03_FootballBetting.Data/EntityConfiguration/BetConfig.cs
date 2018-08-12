using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class BetConfig : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> builder)
        {
            builder.HasKey(e => e.BetId);

            builder.HasOne(e => e.Game)
                   .WithMany(x => x.Bets)
                   .HasForeignKey(g => g.GameId);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Bets)
                   .HasForeignKey(u => u.UserId);
        }
    }
}
