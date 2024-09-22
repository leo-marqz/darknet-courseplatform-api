
using System;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using DarkNetCoursePlatform.Domain.Models;
using DarkNetCoursePlatform.Persistence;
using DarkNetCoursePlatform.Persistence.SystemModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
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

                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

                if(!userManager.Users.Any()){
                    var admin = new ApplicationUser {
                        FullName = "Leonel Marquez",
                        UserName = "leomarqz",
                        Email = "leonel.marquez@leomarqz.com"
                    };
                    await userManager.CreateAsync(admin, "$ABC123Admin");
                    await userManager.AddToRoleAsync(admin, SystemRoles.ADMIN);

                    var client = new ApplicationUser {
                        FullName = "Vilma Torres",
                        UserName = "vitorres",
                        Email = "vilma.torres@leomarqz.com"
                    };
                    await userManager.CreateAsync(client, "$ABC123Client");
                    await userManager.AddToRoleAsync(client, SystemRoles.CLIENT);
                }

                var courses = await context.Courses!.Take(10).Skip(0).ToListAsync();
                
                if(!context.Set<CourseInstructor>().Any()){
                    var instructors = await context.Instructors!.Take(10).Skip(0).ToListAsync();

                    foreach(var course in courses){
                        course.Instructors = instructors; // add the instructors to the course
                    }
                }

                if(!context.Set<CoursePrice>().Any()){
                    var prices = await context.Prices!.Take(10).Skip(0).ToListAsync();

                    foreach(var course in courses){
                        course.Prices = prices; // add the prices to the course
                    }
                }

                if(!context.Set<Rating>().Any()){

                    foreach(var course in courses){
                        var ratingFake = new Faker<Rating>()
                            .RuleFor((rt)=> rt.Id, _=> Guid.NewGuid())
                            .RuleFor((rt)=> rt.CourseId, _=> course.Id)
                            .RuleFor((rt)=> rt.Student, (fk)=> fk.Name.FullName())
                            .RuleFor((rt)=> rt.Score, (fk)=> fk.Random.Int(3, 5))
                            .RuleFor((rt)=> rt.Comment, (fk)=>fk.Commerce.ProductDescription());
                        
                        var ratings = ratingFake.Generate(3);
                        context.Ratings!.AddRange(ratings);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DarkNetCoursePlatformDbContext>();
                logger.LogError(ex, "An error occurred during migration");
            }
        }
    }
}