using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(i=>i.Title).NotEmpty().WithMessage("Görsel başlığı boş geçilemez");
            RuleFor(i=>i.Description).NotEmpty().WithMessage("Görsel açıklaması boş geçilemez");
            RuleFor(i=>i.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçilemez");
            RuleFor(i => i.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter kullanınız");
            RuleFor(i => i.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter kullanınız");
            RuleFor(i => i.Description).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter kullanınız");
            RuleFor(i => i.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter kullanınız");
        }
    }
}
