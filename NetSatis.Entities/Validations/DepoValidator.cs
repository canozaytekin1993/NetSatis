using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu alanı boş geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adi alanı boş geçilemez.");
        }
    }
}