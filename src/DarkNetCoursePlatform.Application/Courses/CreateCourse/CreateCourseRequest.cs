

using System;
using Microsoft.AspNetCore.Http;

namespace DarkNetCoursePlatform.Application.Courses.CreateCourse
{
    public class CreateCourseRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Release { get; set; }
        public IFormFile Picture { get; set; }
        public Guid InstructorId { get; set; }
        public Guid PriceId { get; set; }
    }
}