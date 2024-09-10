
using System;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class CoursePrice // Many-to-many relationship between Course and Price
    {
        public Guid CourseId { get; set; } // Course
        public Course Course { get; set; } // Navigation property

        public Guid PriceId { get; set; } // Price
        public Price Price { get; set; } // Navigation property
    }
}