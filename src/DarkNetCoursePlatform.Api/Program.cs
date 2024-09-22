
using DarkNetCoursePlatform.Api.Extensions;
using DarkNetCoursePlatform.Application;
using DarkNetCoursePlatform.Persistence;
using DarkNetCoursePlatform.Persistence.SystemModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // add the controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting((option)=> option.LowercaseUrls = true);

builder.Services.AddApplicationDependencyInjections(); // add the application dependencies
builder.Services.AddPersistenceDependencyInjections(builder.Configuration); // add the persistence dependencies

builder.Services.AddIdentityCore<ApplicationUser>((options)=>{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
    options.User.RequireUniqueEmail = true;
}).AddRoles<IdentityRole>()
  .AddEntityFrameworkStores<DarkNetCoursePlatformDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

await app.seedDataAuthenticationAsync();
// app.UseHttpsRedirection();

app.MapControllers(); // map the controllers
app.Run();


