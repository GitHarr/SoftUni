using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(e => e.TownId);

            builder.HasOne(e => e.Country)
                   .WithMany(c => c.Towns)
                   .HasForeignKey(e => e.CountryId);
        }
    }
}
