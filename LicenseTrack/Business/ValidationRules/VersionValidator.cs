using Entities.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;

public class VersionValidator : AbstractValidator<Entities.Concrete.Version>
{
    public VersionValidator()
    {
        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Sürüm adı boş olamaz.")
            .Must(IsValidVersionName).WithMessage("Sürüm adı 'V01.02.05' formatında olmalı ve major kısmı tek haneli olmalıdır.");

        RuleFor(v => v.Number)
            .InclusiveBetween(100000, 999999).WithMessage("Sürüm numarası 6 haneli olmalıdır.");
    }

    private bool IsValidVersionName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return false;
        var match = Regex.Match(name, @"^V(\d{2})\.(\d{2})\.(\d{2})$");
        return match.Success;
    }
}
