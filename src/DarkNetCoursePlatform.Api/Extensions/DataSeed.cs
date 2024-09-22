
using System;
using System.Threading.Tasks;
using DarkNetCoursePlatform.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DarkNetCoursePlatform.Api.Extensions
{
    public static class DataSeed
    {
        public static async Task seedDataAuthenticationAsync(this IApplicationBuilder app){
            // seed the data
            using var scope  = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var  context = services.GetRequiredService<DarkNetCoursePlatformDbContext>();
                await context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DarkNetCoursePlatformDbContext>();
                logger.LogError(ex, "An error occurred during migration");
            }
        }
    }
}