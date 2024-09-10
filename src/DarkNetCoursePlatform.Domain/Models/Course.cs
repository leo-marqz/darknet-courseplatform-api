
using System.Collections.Generic;

namespace DarkNetCoursePlatform.Domain.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public ICollection<Rating> Ratings { get; set; }
    }
}