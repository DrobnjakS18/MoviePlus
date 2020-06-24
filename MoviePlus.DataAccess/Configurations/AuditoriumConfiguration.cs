using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Configurations
{
    public class AuditoriumConfiguration : IEntityTypeConfiguration<Auditorium>
    {
        public void Configure(EntityTypeBuilder<Auditorium> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(32);
            builder.HasIndex(a => a.Name).IsUnique();

            builder.Property(a => a.SeatNumbers).IsRequired();

            builder.HasMany(a => a.Screenings).WithOne(s => s.Auditorium).HasForeignKey(s => s.AuditoriumId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(a => a.Seats).WithOne(s => s.Auditorium).HasForeignKey(s => s.AuditoriumId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
