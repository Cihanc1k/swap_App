using AlGulumVerGulum.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DAL.EntityFramework.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.PicturePath).HasMaxLength(200);

            builder.HasMany(c => c.Notices).WithOne(n => n.Category).HasForeignKey(n => n.CategoryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
