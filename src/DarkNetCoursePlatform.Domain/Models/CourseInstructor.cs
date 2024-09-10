using System;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class CourseInstructor // Many-to-Many relationship
    {
        public Guid CourseId { get; set; } // Composite key
        public Course Course { get; set; } // Navigation property

        public Guid InstructorId { get; set; } // Composite key
        public Instructor Instructor { get; set; } // Navigation property
    }
}