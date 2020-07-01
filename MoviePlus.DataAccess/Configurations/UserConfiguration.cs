using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(32).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(32).IsRequired();

            builder.HasIndex(x => x.Username).IsUnique();
            builder.Property(x => x.Username).HasMaxLength(32).IsRequired();

            //Password nije zavrsen
            builder.Property(x => x.Password).HasMaxLength(32).IsRequired();

            builder.HasMany(x => x.Reservations).WithOne(o => o.User).HasForeignKey(o => o.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.UserUseCases).WithOne(o => o.Users).HasForeignKey(o => o.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
