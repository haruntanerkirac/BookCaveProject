using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad ve soyad alanı boş bırakılamaz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter giriniz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter giriniz!");
        }
    }
}
