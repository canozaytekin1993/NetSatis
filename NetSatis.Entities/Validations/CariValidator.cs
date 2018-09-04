using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu alanı boş geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı alanı boş geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi alanı boş geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı alanı boş geçilemez.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Girdiğiniz email adresi geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı alanı 0'dan küçük olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti alanı 0'dan küçük olamaz.");
        }
    }
}