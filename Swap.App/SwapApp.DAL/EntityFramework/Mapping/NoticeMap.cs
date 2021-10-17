using AlGulumVerGulum.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DAL.EntityFramework.Mapping
{
    public class NoticeMap : IEntityTypeConfiguration<Notice>
    {
        public void Configure(EntityTypeBuilder<Notice> builder)
        {
            builder.Property(n => n.Description).IsRequired();
            builder.Property(n => n.Title).HasMaxLength(100).IsRequired();


            builder.HasOne(x => x.Owner).WithMany(x => x.Notices).HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Pictures).WithOne(x => x.Notice).HasForeignKey(x => x.NoticeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Requests).WithMany(x => x.Notices);
        }
    }
}
