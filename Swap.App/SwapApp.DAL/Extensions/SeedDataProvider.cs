using AlGulumVerGulum.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DAL.Extensions
{
    public static class SeedDataProvider
    {
        public static void AddSeedData(this ModelBuilder builder)
        {
            // SEED DATA
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronik", Description = "Tüm elektronik ürünler burada" },
                new Category { Id = 2, Name = "Mobilya", Description = "Tüm mobilya ürünleri burada" },
                new Category { Id = 3, Name = "Giyim", Description = "Tüm giyim ürünleri" }
                );
        }
    }
}
