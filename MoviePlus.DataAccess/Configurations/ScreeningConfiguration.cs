using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Configurations
{
    public class ScreeningConfiguration : IEntityTypeConfiguration<Screening>
    {
        public void Configure(EntityTypeBuilder<Screening> builder)
        {
            builder.Property(s => s.ScreeningTime).IsRequired();

            builder.HasMany(a => a.SeatReserved).WithOne(s => s.Screening).HasForeignKey(s => s.ScreeningId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
