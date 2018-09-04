using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu alanı boş geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Adi alanı boş geçilemez.");
        }
    }
}