
using System;
using System.Collections.Generic;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Release { get; set; } // 
        
        public ICollection<Rating> Ratings { get; set; } // Navigation property
        public ICollection<Price> Prices { get; set; } // Navigation property
        public ICollection<CoursePrice> CoursePrices { get; set; } // Navigation property
        public ICollection<Instructor> Instructors { get; set; } // Navigation property
        public ICollection<CourseInstructor> CourseInstructors { get; set; } // Navigation property
        public ICollection<Picture> Pictures { get; set; }
    }
}