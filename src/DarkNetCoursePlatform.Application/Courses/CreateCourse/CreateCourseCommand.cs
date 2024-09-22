using System;
using System.Threading;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Domain.Models;
using DarkNetCoursePlatform.Persistence;
using MediatR;

namespace DarkNetCoursePlatform.Application.Courses.CreateCourse;

public class CreateCourseCommand
{
    public record CreateCourseCommandRequest(CreateCourseRequest createRequest) : IRequest<Guid>;

    internal class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest, Guid>
    {
        private readonly DarkNetCoursePlatformDbContext _context;

        public CreateCourseCommandHandler(DarkNetCoursePlatformDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateCourseCommandRequest commandRequest, CancellationToken cancellationToken)
        {
            var course = new Course {
                Id = Guid.NewGuid(),
                Title = commandRequest.createRequest.Title,
                Description = commandRequest.createRequest.Description,
                Release = commandRequest.createRequest.Release
            };
            
            _context.Courses.Add(course);
            await _context.SaveChangesAsync(cancellationToken);

            return course.Id;
        }
    }
}
