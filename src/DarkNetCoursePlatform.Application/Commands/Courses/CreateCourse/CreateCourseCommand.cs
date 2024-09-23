using System;
using System.Threading;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Application.Core;
using DarkNetCoursePlatform.Domain.Models;
using DarkNetCoursePlatform.Persistence;
using MediatR;

namespace DarkNetCoursePlatform.Application.Commands.Courses.CreateCourse;

public class CreateCourseCommand
{
    public record CreateCourseCommandRequest(CreateCourseRequest createRequest) : IRequest<Result<Guid>>;

    internal class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest, Result<Guid> >
    {
        private readonly DarkNetCoursePlatformDbContext _context;

        public CreateCourseCommandHandler(DarkNetCoursePlatformDbContext context)
        {
            _context = context;
        }

        public async Task<Result<Guid>> Handle(CreateCourseCommandRequest commandRequest, CancellationToken cancellationToken)
        {
            var course = new Course {
                Id = Guid.NewGuid(),
                Title = commandRequest.createRequest.Title,
                Description = commandRequest.createRequest.Description,
                Release = commandRequest.createRequest.Release
            };
            
            _context.Courses.Add(course);
            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0
                ? Result<Guid>.Success(course.Id)
                : Result<Guid>.Failure("Failed to create course");
        }
    }
}
