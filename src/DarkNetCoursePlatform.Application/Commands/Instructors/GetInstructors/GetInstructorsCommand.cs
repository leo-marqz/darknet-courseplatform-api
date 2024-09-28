using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkNetCoursePlatform.Application.Commands.Instructors.GetInstructors
{
    public class GetInstructorsCommand
    {
    }
    
    public record InstructorReponse (
        Guid Id,
        string Name,
        string LastName,
        string AcademyDegree
    );
}