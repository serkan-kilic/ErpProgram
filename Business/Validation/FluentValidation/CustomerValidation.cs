using DataAccess.Abstract;
using DevExpress.XtraReports.Design;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class CustomerValidation : AbstractValidator<customer>
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerValidation(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

            RuleFor(x => x.customertypeid).NotEmpty().WithMessage("Müşteri tipi boş bırakılamaz.");
            RuleFor(x => x.districtid).NotEmpty().WithMessage("İl ve ilçe boş bırakılamaz.");
            RuleFor(x => x.phonenumber).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz.").Length(14).WithMessage("Telefon numarası 11 karakterden oluşmalıdır.").Must((customer,phonenumber) => IsPhoneNumberUnique(customer.id,phonenumber)).WithMessage("Telefon numarası eşsiz olmalıdır");
            RuleFor(x => x.email).NotEmpty().WithMessage("E-posta boş bırakılamaz.").Must((customer,email) => IsEmailUnique(customer.id,email));
            RuleFor(x => x.currency).NotEmpty().WithMessage("Para birimi boş bırakılamaz.");

            When(x => x.customertypeid == 2, () =>
            {
                RuleFor(x => x.tckn).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Tc kimlik numarası boş bırakılamaz.").Length(11).WithMessage("Tc kimlik numarası 11 karakterden oluşmalıdır.").Must((customer,tckn) => IsTcknUnique(customer.id,tckn)).WithMessage("Tc kimlik numarası eşsiz olmalıdır");
                RuleFor(x => x.name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("İsim boş bırakılamaz.").MinimumLength(3).WithMessage("İsim en az 3 karakterden oluşmalıdır.");
                RuleFor(x => x.name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Soyisim boş bırakılamaz.").MinimumLength(3).WithMessage("Soyisim en az 3 karakterden oluşmalıdır.");
                
            });
            When(x => x.customertypeid == 3, () =>
            {
                RuleFor(x => x.vkn).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Vergi kimlik numarası boş bırakılamaz.").Length(10).WithMessage("Vergi kimlik numarası 10 karakterden oluşmalıdır.").Must((customer,vkn) => IsVknUnique(customer.id,vkn)).WithMessage("Vergi kimlik numarası eşsiz olmalıdır");
                RuleFor(x => x.title).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Şirket adı boş bırakılamaz").MinimumLength(3).WithMessage("Şirket adı en az 3 karakterden oluşmalıdır");
                RuleFor(x => x.taxoffice).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("Vergi dairesi boş bırakılamaz.").MinimumLength(3).WithMessage("Vergi dairesi en az 3 karakterden oluşmalıdır.");
            });
        }
        private bool IsTcknUnique(int id, string tckn)
        {
            return !_customerRepository.GetAll().Any(x => x.tckn == tckn && x.id != id);
        }
        private bool IsVknUnique(int id, string vkn)
        {
            return !_customerRepository.GetAll().Any(x => x.vkn == vkn && x.id != id);
        }
        private bool IsPhoneNumberUnique(int id, string number)
        {
            return !_customerRepository.GetAll().Any(x => x.phonenumber == number && x.id != id);
        }
        private bool IsEmailUnique(int id, string email)
        {
            return !_customerRepository.GetAll().Any(x => x.email == email && x.id != id);
        }
    }
}
