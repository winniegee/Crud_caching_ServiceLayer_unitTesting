using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

namespace RLS.AwesomeBar.API.Database
{
    public class BarContext : DbContext//, IDbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Cocktail> Cocktails { get; set; }

        public BarContext(DbContextOptions<BarContext> options)
        : base(options)
        {
        }
        public BarContext()
        {

        }
        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            var jsonString = File.ReadAllText("./Database/Seed/cocktails.json");

            var seedData = JsonSerializer.Deserialize<List<SeedItem>>(jsonString);

            foreach (var category in seedData.Select(s => s.Category).Distinct())
            {
                modelBuilder.Entity<Category>().HasData(new Category
                {
                    ID = Guid.NewGuid(),
                    Name = category,
                    CreatedAt = DateTime.UtcNow,
                });
            }

            foreach (var ingredient in seedData.SelectMany(s => s.Ingredients).Distinct())
            {
                modelBuilder.Entity<Ingredient>().HasData(new Ingredient
                {
                    ID = Guid.NewGuid(),
                    Name = ingredient,
                    CreatedAt = DateTime.UtcNow,
                });
            }
            foreach (var cocktail in seedData)
            {
                modelBuilder.Entity<Cocktail>().HasData(new Cocktail
                {
                    ID = Guid.NewGuid(),
                    Name = cocktail.Name,
                    AlternateName = cocktail.AlternateName,
                    Category = cocktail.Category,
                    Image = cocktail.Image,
                    Ingredients = string.Join(", ", cocktail.Ingredients),
                    Instructions = cocktail.Instructions,
                    Measures = cocktail.Measures,
                    Tags = cocktail.Tags
                });
            }

        }
    }
}
