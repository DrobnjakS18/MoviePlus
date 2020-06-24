using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.Title).IsRequired().HasMaxLength(100);
            builder.HasIndex(m => m.Title).IsUnique();

            builder.Property(m => m.Description).IsRequired().HasMaxLength(1500);
            builder.HasIndex(m => m.Description).IsUnique();

            builder.Property(m => m.Duration).IsRequired();

            builder.HasMany(m => m.Screenings).WithOne(s => s.Movie).HasForeignKey(s => s.MovieId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
