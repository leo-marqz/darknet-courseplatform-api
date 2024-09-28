using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DarkNetCoursePlatform.Application.Commands.Instructors.GetInstructors;
using DarkNetCoursePlatform.Application.Commands.Pictures.GetPictures;
using DarkNetCoursePlatform.Application.Commands.Prices.GetPrices;
using DarkNetCoursePlatform.Application.Commands.Ratings.GetRatings;
using DarkNetCoursePlatform.Application.Core;
using DarkNetCoursePlatform.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DarkNetCoursePlatform.Application.Commands.Courses.GetCourses
{
    public class GetCourseCommand
    {
        public record GetCourseCommandRequest : IRequest<Result<CourseResponse>>{
            public Guid Id { get; set; }
        }

        internal class GetCourseCommandHandler 
        : IRequestHandler<GetCourseCommandRequest, Result<CourseResponse>>
        {
            private readonly DarkNetCoursePlatformDbContext _context;
            private readonly IMapper _mapper;

            public GetCourseCommandHandler( DarkNetCoursePlatformDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<CourseResponse>> Handle( GetCourseCommandRequest request, CancellationToken cancellationToken)
            {
                var course = await _context.Courses.Where(c => c.Id == request.Id)
                                                   .Include(x => x.Instructors)
                                                    .Include(x => x.Ratings)
                                                    .Include(x => x.Prices)
                                                    .ProjectTo<CourseResponse>(_mapper.ConfigurationProvider)
                                                    .FirstOrDefaultAsync(cancellationToken);
                return course != null
                    ? Result<CourseResponse>.Success(course)
                    : Result<CourseResponse>.Failure("Course not found");

            }
        }
    }

    public record CourseResponse(
        Guid Id, 
        string Title, 
        string Description, 
        DateTime Release,
        List<InstructorReponse> Instructors,
        List<RatingResponse> Ratings,
        List<PriceResponse> Prices,
        List<PictureResponse> Pictures
    );
}