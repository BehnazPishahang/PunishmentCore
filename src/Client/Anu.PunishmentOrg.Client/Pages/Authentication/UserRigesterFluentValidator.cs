using Anu.Commons.ServiceModel.ServiceAuthentication;
using FluentValidation;

namespace Anu.PunishmentOrg.Client.Pages.Authentication
{
 

    public class UserRigesterFluentValidator : AbstractValidator<UserRegisterRequest>
    {
        public UserRigesterFluentValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(1, 100)
                .CreditCard();

            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .Length(1, 11);

        }
    }



}
