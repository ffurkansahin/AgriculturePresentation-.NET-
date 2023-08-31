using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(i => i.Description1).NotEmpty().WithMessage("Açıklama 1 boş geçilemez");
            RuleFor(i => i.Description2).NotEmpty().WithMessage("Açıklama 2 boş geçilemez");
            RuleFor(i => i.Description3).NotEmpty().WithMessage("Açıklama 3 boş geçilemez");
            RuleFor(i => i.Description4).NotEmpty().WithMessage("Açıklama 4 boş geçilemez");
            RuleFor(i => i.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez");
            RuleFor(i => i.Description1).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(i => i.Description2).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(i => i.Description3).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(i => i.Description4).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            
        }
    }
}
