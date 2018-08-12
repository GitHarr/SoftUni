using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.TeamId);

            builder.HasOne(e => e.PrimaryKitColor)
                   .WithMany(pkc => pkc.PrimaryKitTeams)
                   .HasForeignKey(e => e.PrimaryKitColorId);

            builder.HasOne(e => e.SecondaryKitColor)
                   .WithMany(skc => skc.SecondaryKitTeams)
                   .HasForeignKey(e => e.SecondaryKitColorId);

            builder.HasOne(e => e.Town)
                   .WithMany(t => t.Teams)
                   .HasForeignKey(e => e.TownId);
        }
    }
}
