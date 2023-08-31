using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(i => i.PersonName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez");
            RuleFor(i => i.Title).NotEmpty().WithMessage("Görev Kısmı Boş Geçilemez");
            RuleFor(i => i.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez");
            RuleFor(i => i.PersonName).MaximumLength(50).WithMessage("Maximum Karakter Sayısı 50dir");
            RuleFor(i => i.PersonName).MinimumLength(5).WithMessage("En Az Karakter Sayısı 5dir");
            RuleFor(i => i.Title).MaximumLength(50).WithMessage("Maximum Karakter Sayısı 50dir");
            RuleFor(i => i.Title).MinimumLength(3).WithMessage("En Az Karakter Sayısı 3dir");
        }
    }
}
