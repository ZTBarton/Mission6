using System;
using Microsoft.EntityFrameworkCore;
namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }
    
        //public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            //mb.Entity<Category>().HasData(
            //    new Category
            //    {
            //        CategoryId = 1,
            //        CategoryName = "Home"

            //    },
            //     new Category
            //     {
            //         CategoryId = 2,
            //         CategoryName = "School"
            //     },
            //     new Category
            //     {
            //         CategoryId = 3,
            //         CategoryName = "Work"
            //     },
            //    new Category
            //    {
            //        CategoryId = 4,
            //        CategoryName = "Church"
            //    },


            //);




            //mb.Entity<AppResponse>().HasData(
            //    new AppResponse
            //    {
            //        MovieId = 1,
            //        Title = "Hot Rod",
            //        Year = 2009,
            //        Category = "Comedy",
            //        Director = "Sam Robertson",
            //        Rating = "PG-13",
            //        Edited = false,
            //        Notes = "It's a great movie"
            //    },
            //     new AppResponse
            //     {
            //         MovieId = 2,
            //         Title = "Blades of Glory",
            //         Year = 2012,
            //         Category = "Comedy",
            //         Director = "Zach Barton",
            //         Rating = "PG-13",
            //         Edited = false,
            //         Notes = "Kanye has a song that features this film"
            //     },
            //     new AppResponse
            //     {
            //         MovieId = 3,
            //         Title = "La La Land",
            //         Year = 2017,
            //         Category = "Musical",
            //         Director = "Josh Baxter",
            //         Rating = "PG-13",
            //         Edited = false,
            //         Notes = "If you don't like this movie then you need better opinions"
            //     }
            //);
        }
    }
}




