
using System;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class Picture : BaseEntity
    {
        public string Url { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}