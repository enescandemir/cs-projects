using Entities.Concrete;
using FluentValidation;
using System.Net;
using System.Net.Sockets;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Müşteri adı boş olamaz.")
            .MinimumLength(3).WithMessage("Müşteri adı en az 3 karakter olmalıdır.");

        RuleFor(c => c.Port)
            .InclusiveBetween(1, 65535)
            .When(c => c.Port.HasValue)
            .WithMessage("Port değeri 1 ile 65535 arasında olmalıdır.");

        RuleFor(c => c.Address)
            .Must(BeAValidIPv4)
            .When(c => !string.IsNullOrWhiteSpace(c.Address))
            .WithMessage("Adres geçerli bir IPv4 adresi olmalıdır (örnek: 192.168.1.1).");

        RuleFor(c => c.DBName)
            .MinimumLength(3)
            .When(c => !string.IsNullOrWhiteSpace(c.DBName))
            .WithMessage("Veritabanı adı en az 3 karakter olmalıdır.");
    }

    private bool BeAValidIPv4(string address)
    {
        return IPAddress.TryParse(address, out var ip) && ip.AddressFamily == AddressFamily.InterNetwork;
    }
}
