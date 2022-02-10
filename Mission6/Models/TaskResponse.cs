using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace Mission6.Models
{
    public class TaskResponse
    {
            [Key]
            [Required]
            public int TaskId { get; set; }
            [Required]
            public string TaskName { get; set; }
            [Required]
            public DateTime DueDate { get; set; }
            [Required]
            public int Quadrant { get; set; }
            public bool Completed { get; set; }

            [Required]
            public int CategoryId { get; set; }
            public Category Category { get; set; }
    }
}

  
