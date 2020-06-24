﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.Property(s => s.Row).IsRequired();

            builder.Property(s => s.Number).IsRequired();

            builder.HasMany(a => a.SeatReserved).WithOne(s => s.Seat).HasForeignKey(s => s.SeatId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}