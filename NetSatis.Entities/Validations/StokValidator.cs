using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu alanı boş geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı alanı boş geçilemez.").Length(5, 50)
                .WithMessage("Stok Adı alanı 5 ile 50 karakter arasında olabilir.");
            RuleFor(p => p.BarkodKodu).NotEmpty().WithMessage("Barkod alanı boş geçilemez.");
            RuleFor(p => p.AlisFiyatı1).GreaterThanOrEqualTo(0)
                .WithMessage("Alış Fiyatı - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyatı2).GreaterThanOrEqualTo(0)
                .WithMessage("Alış Fiyatı - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyatı3).GreaterThanOrEqualTo(0)
                .WithMessage("Alış Fiyatı - 3 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyatı1).GreaterThanOrEqualTo(0)
                .WithMessage("Satış Fiyatı - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyatı2).GreaterThanOrEqualTo(0)
                .WithMessage("Satış Fiyatı - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyatı3).GreaterThanOrEqualTo(0)
                .WithMessage("Satış Fiyatı - 3 alanı 0'dan küçük olamaz.");
        }
    }
}