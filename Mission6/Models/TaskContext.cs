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
        public DbSet<TaskResponse> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }  
            );

            mb.Entity<TaskResponse>().HasData(
                new TaskResponse
                {
                    TaskId = 1,
                    DueDate = "02-14-2022",
                    TaskName = "Plan FHE",
                    Quadrant = 1,
                    CategoryId = 4,
                    Completed = false
                },
                new TaskResponse
                {
                    TaskId = 2,
                    DueDate = "02-14-2022",
                    TaskName = "Plan FHE",
                    Quadrant = 2,
                    CategoryId = 4,
                    Completed = false
                },
                new TaskResponse
                {
                    TaskId = 3,
                    DueDate = "02-14-2022",
                    TaskName = "Plan FHE",
                    Quadrant = 3,
                    CategoryId = 4,
                    Completed = false
                },
                new TaskResponse
                {
                    TaskId = 4,
                    DueDate = "02-14-2022",
                    TaskName = "Plan FHE",
                    Quadrant = 4,
                    CategoryId = 4,
                    Completed = false
                }
            );
        }
    }
}




