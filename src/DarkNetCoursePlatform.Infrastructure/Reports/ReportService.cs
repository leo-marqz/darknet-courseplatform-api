
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;
using DarkNetCoursePlatform.Application.Services.Reports;
using DarkNetCoursePlatform.Domain.Models;

namespace DarkNetCoursePlatform.Infrastructure.Reports
{
    public class ReportService<TEntityReport>
    : IReportService<TEntityReport> where TEntityReport : BaseEntity
    {
        public Task<MemoryStream> GenerateCsvReportAsync(List<TEntityReport> records)
        {
            using var memoryStream = new MemoryStream();
            using var streamWriter = new StreamWriter(memoryStream);
            using var csvWritter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture is used to avoid issues with different cultures
            
            csvWritter.WriteRecords(records); // Write the records to the CSV file
            streamWriter.Flush();
            memoryStream.Seek(0, SeekOrigin.Begin); // Reset the memory stream position to the beginning
            return Task.FromResult(memoryStream);
        }
    }
}