using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Domain.Models;

namespace DarkNetCoursePlatform.Application.Services.Reports
{
    public interface IReportService<TEntityReport> where TEntityReport : BaseEntity
    {
        Task<MemoryStream> GenerateCsvReportAsync(List<TEntityReport> records);
    }
}