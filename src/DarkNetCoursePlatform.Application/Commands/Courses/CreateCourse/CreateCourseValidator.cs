
using FluentValidation;

namespace DarkNetCoursePlatform.Application.Commands.Courses.CreateCourse
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseValidator()
        {
            RuleFor((attr)=> attr.Title).NotEmpty().Length(3, 50).WithMessage("El titulo es requerido");
            RuleFor((attr)=>attr.Description).NotEmpty().Length(15, 200).WithMessage("La descripción es requerida");
            RuleFor((attr)=>attr.Release).NotEmpty().WithMessage("La fecha de lanzamiento es requerida");
        }
    }
}