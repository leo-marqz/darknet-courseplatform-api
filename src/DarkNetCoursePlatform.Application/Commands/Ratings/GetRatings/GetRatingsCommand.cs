using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkNetCoursePlatform.Application.Commands.Ratings.GetRatings
{
    public class GetRatingsCommand
    {
    }
    
    public record RatingResponse(
        Guid Id,
        string CourseName,
        string Student,
        int Score,
        string Comment
    );
}