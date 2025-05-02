using Core.Entities.Concrete;
using FluentValidation;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator(string password)
    {
        RuleFor(u => u.FirstName)
            .NotEmpty().WithMessage("Ad boş olamaz.")
            .MinimumLength(3).WithMessage("Ad en az 3 karakter olmalıdır.");

        RuleFor(u => u.LastName)
            .NotEmpty().WithMessage("Soyad boş olamaz.")
            .MinimumLength(3).WithMessage("Soyad en az 3 karakter olmalıdır.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email boş olamaz.")
            .Matches(@"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$").WithMessage("Geçerli bir email adresi giriniz.");


        RuleFor(u => u)
            .Custom((user, context) =>
            {
                if (string.IsNullOrWhiteSpace(password) ||
                    password.Length < 5 ||
                    !password.Any(char.IsUpper) ||
                    !password.Any(char.IsPunctuation))
                {
                    context.AddFailure("Şifre", "Şifre en az 5 karakter olmalı, bir büyük harf ve bir özel karakter içermelidir.");
                }
            });
    }
}
