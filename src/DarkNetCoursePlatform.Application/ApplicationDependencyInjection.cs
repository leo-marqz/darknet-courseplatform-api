
using Microsoft.Extensions.DependencyInjection;

namespace DarkNetCoursePlatform.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjections(this IServiceCollection services)
        {
            services.AddMediatR((configuration)=>{
                configuration.RegisterServicesFromAssemblies( 
                    assemblies: typeof(ApplicationDependencyInjection).Assembly 
                );
            });
            
            return services;
        }
    }
}