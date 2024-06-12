using AppApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AppApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


       public DbSet<Category> Categories { get; set; }
       public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "UI UX",


                },
                new Category
                {
                    Id=2,
                    CreatedDate= DateTime.Now,
                    Name="Programming"
                },
                new Category
                {
                    Id=3, 
                    CreatedDate= DateTime.Now,
                    Name="Frontend"
                }
                
                );
            base.OnModelCreating(modelBuilder);
        }
    }


}
