
// using DarkNetCoursePlatform.Domain.Models;
// using DarkNetCoursePlatform.Persistence;

// var message = "Archivo de prueba, se configuro la libreria como ejecutable temporalmente";
// Console.WriteLine(message);
// Console.WriteLine("".PadLeft(message.Length, '-'));

// using var context = new DarkNetCoursePlatformDbContext();

// var newCourse = new Course{
//     Id = Guid.NewGuid(),
//     Title = "Curso de C#",
//     Description = "Curso de C# para principiantes",
//     Release = DateTime.UtcNow.AddDays(1)
// };

// context.Courses.Add(newCourse);
// var result = context.SaveChanges();

// Console.WriteLine($"Se agregaron {result} registros a la base de datos");

// List<Course> courses = context.Courses.ToList();

// foreach (var course in courses)
// {
//     Console.WriteLine($"Course({course.Id}): {course.Title}");
// }
