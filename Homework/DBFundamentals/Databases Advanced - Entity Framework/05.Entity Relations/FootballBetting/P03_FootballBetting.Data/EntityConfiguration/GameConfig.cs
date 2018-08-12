using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(x => x.GameId);

            builder.HasOne(e => e.HomeTeam)
                   .WithMany(h => h.HomeGames)
                   .HasForeignKey(x => x.HomeTeamId);

            builder.HasOne(e => e.AwayTeam)
                   .WithMany(at => at.AwayGames)
                   .HasForeignKey(e => e.AwayTeamId);
        }
    }
}
