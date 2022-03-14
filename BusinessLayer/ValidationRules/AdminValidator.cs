using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Admin kullanıcı adını boş geçemezsiniz");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Şifreyi boş geçemezsiniz");
            RuleFor(x => x.AdminRole).NotEmpty().WithMessage("Lütfen rol kısmını boş geçmeyiniz");
            RuleFor(x => x.AdminUserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.AdminPassword).MinimumLength(4).WithMessage("Lütfen en az 4 karakter giriniz");


        }
    }
}
