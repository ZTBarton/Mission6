using System;
using Microsoft.EntityFrameworkCore;
namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Home"

                },
                 new Category
                 {
                     CategoryId = 2,
                     CategoryName = "School"
                 },
                 new Category
                 {
                     CategoryId = 3,
                     CategoryName = "Work"
                 },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Church"
                }
            );




            mb.Entity<TaskResponse>().HasData(
                new TaskResponse
                {
                    TaskId = 1,
                    DueDate = new DateTime(2023, 5, 1),
                    Quadrant = 1,
                    Category = "Church",
                    Completed = false
             
                }
            
            );
        }
    }
}




