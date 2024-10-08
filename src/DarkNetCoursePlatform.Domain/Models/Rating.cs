
using System;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class Rating : BaseEntity
    {
        public Guid CourseId { get; set; } // Course rated
        public string Student { get; set; } // Student who rated
        public Course Course { get; set; } // Navigation property
        public int Score { get; set; } // 1-5 scale
        public string Comment { get; set; } // Optional comment
    }
}