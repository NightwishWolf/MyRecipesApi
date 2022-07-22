using Microsoft.EntityFrameworkCore;
using RecipeApi.Models;
using System.Diagnostics.CodeAnalysis;

namespace RecipeApi.Data

{
    public class ApplicationDbContext : DbContext
{   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

    public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
}

       
}
