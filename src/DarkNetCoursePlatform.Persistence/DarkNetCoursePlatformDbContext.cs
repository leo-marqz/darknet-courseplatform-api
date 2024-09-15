
using Bogus;
using DarkNetCoursePlatform.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DarkNetCoursePlatform.Persistence;

public class DarkNetCoursePlatformDbContext : DbContext
{
    // public DarkNetCoursePlatformDbContext(DbContextOptions options) : base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use SQLite database
        optionsBuilder.UseSqlite("Data Source=DarkNetCoursePlatform.db")
                      .LogTo(
                            Console.WriteLine, // Log to console
                            new []{ DbLoggerCategory.Database.Command.Name }, // Log only database commands 
                            Microsoft.Extensions.Logging.LogLevel.Information ) // Log level
                        .EnableSensitiveDataLogging(); // Enable sensitive data logging
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Course>().ToTable("courses"); // Map Course model to courses table
        modelBuilder.Entity<Instructor>().ToTable("instructors"); // Map Instructor model to instructors table
        modelBuilder.Entity<CourseInstructor>().ToTable("course_instructors"); // Map CourseInstructor model to course_instructors table
        modelBuilder.Entity<Price>().ToTable("prices"); // Map Price model to prices table
        modelBuilder.Entity<CoursePrice>().ToTable("course_prices"); // Map CoursePrice model to course_prices table
        modelBuilder.Entity<Rating>().ToTable("ratings"); // Map Rating model to ratings table
        modelBuilder.Entity<Picture>().ToTable("pictures"); // Map Picture model to pictures table

        // Configure Price model properties
        modelBuilder.Entity<Price>().Property((pr)=>pr.CurrentPrice).HasPrecision(10,2).IsRequired();
        modelBuilder.Entity<Price>().Property((pr)=>pr.PromotionalPrice).HasPrecision(10,2);
        modelBuilder.Entity<Price>().Property((pr)=>pr.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();

        modelBuilder.Entity<Course>()
            .HasMany(c => c.Pictures) // Course has many Pictures
            .WithOne(p => p.Course) // Picture has one Course
            .HasForeignKey(p => p.CourseId) // Foreign key
            .IsRequired() // Required
            .OnDelete(DeleteBehavior.Cascade); // When Course is deleted, delete Pictures
        
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Ratings) // Course has many Ratings
            .WithOne(r => r.Course) // Rating has one Course
            .HasForeignKey(r => r.CourseId) // Foreign key
            .OnDelete(DeleteBehavior.Restrict); // When Course is deleted, restrict deletion of Ratings

        modelBuilder.Entity<Course>() 
            .HasMany(c => c.Prices) // Course has many Prices
            .WithMany(p => p.Courses) // Price has many Courses
            .UsingEntity<CoursePrice>( // Using CoursePrice as join entity for many-to-many relationship
                (cp)=>cp.HasOne(p=>p.Price).WithMany(p=>p.CoursePrices).HasForeignKey(p=>p.PriceId), // Price has many CoursePrices
                (cp)=>cp.HasOne(c=>c.Course).WithMany(c=>c.CoursePrices).HasForeignKey(c=>c.CourseId), // Course has many CoursePrices
                (cp)=>cp.HasKey(cp=>new{cp.CourseId,cp.PriceId}) // Composite key
            ); 

        modelBuilder.Entity<Course>()
            .HasMany(c => c.Instructors) // Course has many Instructors
            .WithMany(i => i.Courses) // Instructor has many Courses
            .UsingEntity<CourseInstructor>( // Using CourseInstructor as join entity for many-to-many relationship
                (ci)=>ci.HasOne(i=>i.Instructor).WithMany(i=>i.CourseInstructors).HasForeignKey(i=>i.InstructorId), // Instructor has many CourseInstructors
                (ci)=>ci.HasOne(c=>c.Course).WithMany(c=>c.CourseInstructors).HasForeignKey(c=>c.CourseId), // Course has many CourseInstructors
                (ci)=>ci.HasKey(ci=>new{ci.CourseId,ci.InstructorId}) // Composite key
            );

    }

    private Tuple<Course[], Price[], Instructor[]> DataFakeMaster(){

        var courses = new List<Course>();
        var faker = new Faker();

        for(int i=1; i <= 10; i++){
            courses.Add(new Course {
                Id = Guid.NewGuid(),
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Release = DateTime.UtcNow.AddDays(10)
            });
        }
        
        var prices = new List<Price>();
        prices.Add(new Price {
            Id = Guid.NewGuid(),
            Name = "Precio Regular",
            CurrentPrice = 11.99m,
            PromotionalPrice = 75.0m
        });

        //definition
        var fakerInstructors = new Faker<Instructor>()
            .RuleFor((fi)=> fi.Id, ()=> Guid.NewGuid())
            .RuleFor((fi)=> fi.Name, (fk)=> fk.Name.FirstName())
            .RuleFor((fi)=> fi.LastName, (fk)=> fk.Name.LastName())
            .RuleFor((fi)=> fi.AcademyDegree, (fk)=>fk.Name.JobTitle());
        
        var instructors = fakerInstructors.Generate(10);

        return null;
    }
    public DbSet<Course> Courses { get; set; } // DbSet for Course model
    public DbSet<Price> Prices { get; set; } // DbSet for Price model
    public DbSet<Rating> Ratings { get; set; } // DbSet for Rating model
    public DbSet<Picture> Pictures { get; set; } // DbSet for Picture model
    public DbSet<Instructor> Instructors { get; set; } // DbSet for Instructor model
}
