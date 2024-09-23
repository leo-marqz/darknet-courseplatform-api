using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Application.Services.Reports;
using DarkNetCoursePlatform.Domain.Models;
using DarkNetCoursePlatform.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DarkNetCoursePlatform.Application.Commands.Courses.CourseCsvReport
{
    public class CourseCsvReportQuery
    {
        public record CourseCsvReportQueryRequest : IRequest<MemoryStream>;

        internal class CourseCsvReportQueryHandler : IRequestHandler<CourseCsvReportQueryRequest, MemoryStream>
        {
            private readonly DarkNetCoursePlatformDbContext _context;
            private readonly IReportService<Course> _reportService;

            public CourseCsvReportQueryHandler(DarkNetCoursePlatformDbContext context, IReportService<Course> reportService)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
                _reportService = reportService ?? throw new ArgumentNullException(nameof(reportService));
            }

            public async Task<MemoryStream> Handle(CourseCsvReportQueryRequest request, CancellationToken cancellationToken)
            {
                var courses = await _context.Courses.Take(10).Skip(0).ToListAsync(cancellationToken);
                return await _reportService.GenerateCsvReportAsync(courses);
            }
        }
    }
}