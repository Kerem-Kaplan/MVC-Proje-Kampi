using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçmeyiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazarın soyadını boş geçmeyiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçmeyiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Lütfen mail bilgisini boş geçmeyiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Lütfen yazar ünvanını boş geçmeyiniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Lütfen şifre kısmını boş geçmeyiniz");
            RuleFor(x => x.WriterPassword).MinimumLength(4).WithMessage("Lütfen en az 4 karakterli bir şifre giriniz");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("Hakkımda kısmına 100 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
            
        }
    }
}
