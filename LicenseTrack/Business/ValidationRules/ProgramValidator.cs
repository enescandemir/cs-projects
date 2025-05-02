using Entities.Concrete;
using FluentValidation;

public class ProgramValidator : AbstractValidator<Program>
{
    public ProgramValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Program adı boş olamaz.")
            .MinimumLength(3).WithMessage("Program adı en az 3 karakter olmalıdır.");
    }
}
