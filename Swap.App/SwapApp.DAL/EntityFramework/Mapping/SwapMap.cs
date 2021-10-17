using AlGulumVerGulum.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DAL.EntityFramework.Mapping
{
    public class SwapMap : IEntityTypeConfiguration<Swap>
    {
        public void Configure(EntityTypeBuilder<Swap> builder)
        {
            builder.Property(x => x.SenderComment).HasMaxLength(400);
            builder.Property(x => x.TargetComment).HasMaxLength(400);

            builder.HasMany(x => x.Envelopes).WithOne(x => x.Swap).HasForeignKey(x => x.SwapId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}