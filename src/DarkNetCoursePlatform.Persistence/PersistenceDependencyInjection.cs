
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DarkNetCoursePlatform.Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddPersistenceDependencyInjections(
            this IServiceCollection services, 
            IConfiguration configuration
            )
        {
            services.AddDbContext<DarkNetCoursePlatformDbContext>((options)=>{
                options.LogTo( 
                            Console.WriteLine, 
                            new []{ DbLoggerCategory.Database.Command.Name }, 
                            Microsoft.Extensions.Logging.LogLevel.Information )
                        .EnableSensitiveDataLogging();
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}