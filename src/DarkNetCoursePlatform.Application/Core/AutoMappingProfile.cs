using AutoMapper;
using DarkNetCoursePlatform.Application.Commands.Courses.GetCourses;
using DarkNetCoursePlatform.Application.Commands.Instructors.GetInstructors;
using DarkNetCoursePlatform.Application.Commands.Pictures.GetPictures;
using DarkNetCoursePlatform.Application.Commands.Prices.GetPrices;
using DarkNetCoursePlatform.Application.Commands.Ratings.GetRatings;
using DarkNetCoursePlatform.Domain.Models;

namespace DarkNetCoursePlatform.Application.Core
{
    public class AutoMappingProfile : Profile
    {
        protected AutoMappingProfile()
        {
            CreateMap<Course, CourseResponse>();
            CreateMap<Picture, PictureResponse>();
            CreateMap<Rating, RatingResponse>()
                        .ForMember(
                            (dest)=> dest.CourseName, 
                            (src)=> src.MapFrom( (rt)=> rt.Course.Title) );
            CreateMap<Instructor, InstructorReponse>();
            CreateMap<Price, PriceResponse>();
        }
    }
}