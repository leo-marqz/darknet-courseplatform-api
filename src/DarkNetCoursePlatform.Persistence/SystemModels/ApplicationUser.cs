
using Microsoft.AspNetCore.Identity;

namespace DarkNetCoursePlatform.Persistence.SystemModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string AcademyDegree { get; set; } 
    }
}