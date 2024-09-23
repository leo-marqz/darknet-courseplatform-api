
using System;
using System.Threading;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Application.Courses.CreateCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static DarkNetCoursePlatform.Application.Courses.CourseCsvReport.CourseCsvReportQuery;
using static DarkNetCoursePlatform.Application.Courses.CreateCourse.CreateCourseCommand;

namespace DarkNetCoursePlatform.Api.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController : ControllerBase
{
    private readonly ISender _sender;
    
    public CoursesController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("create")]
    public async Task<ActionResult<Guid>> CreateCourse([FromForm] CreateCourseRequest request, CancellationToken cancellationToken)
    {
        var command = new CreateCourseCommandRequest(request);
        var result = await _sender.Send(command, cancellationToken);
        return Ok(result);
    }

    [HttpGet("get-csv-report")]
    public async Task<ActionResult> GenerateCsvReport(CancellationToken cancellationToken)
    {
        var query = new CourseCsvReportQueryRequest();
        var result = await _sender.Send(query, cancellationToken);
        byte[] csv = result.ToArray();
        return File(csv, "text/csv", "reports.csv");
    }

}
