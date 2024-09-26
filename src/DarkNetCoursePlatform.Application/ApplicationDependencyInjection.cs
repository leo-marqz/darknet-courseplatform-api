
using DarkNetCoursePlatform.Application.Commands.Courses.CreateCourse;
using FluentValidation;
using FluentValidation.AspNetCore;
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
            services.AddFluentValidationAutoValidation(); // add the fluent validation
            services.AddValidatorsFromAssemblyContaining<CreateCourseCommand>(); // add the validators
            
            return services;
        }
    }
}