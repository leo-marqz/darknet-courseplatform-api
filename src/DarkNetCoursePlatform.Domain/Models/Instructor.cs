
namespace DarkNetCoursePlatform.Domain.Models
{
    public class Instructor : BaseEntity
    {
        public string Name { get; set; } // Name only
        public string LastName { get; set; } // Last name only
        public string AcademyDegree { get; set; } 
    }
}