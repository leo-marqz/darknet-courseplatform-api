using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkNetCoursePlatform.Application.Commands.Pictures.GetPictures
{
    public class GetPicturesCommand
    {
    }
    
    public record PictureResponse(
        Guid Id,
        Guid CourseId,
        string Url
    );
}