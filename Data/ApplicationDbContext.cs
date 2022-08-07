using Microsoft.EntityFrameworkCore;
using RecipeApi.Models;
using System.Diagnostics.CodeAnalysis;

namespace RecipeApi.Data

{
    public class ApplicationDbContext : DbContext
{   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Recipe> Recipes { get; set; } 
        public virtual DbSet<User> Users { get; set; } 
        public virtual DbSet<Group> Groups { get; set; }
}

       
}
