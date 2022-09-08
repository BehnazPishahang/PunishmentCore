using Anu.PunishmentOrg.ServiceModel.Gravamen;
using FluentValidation;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
 


    public class PersonValidator : AbstractValidator<PGravamenPersonContract>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Address)
                .NotEmpty()
                .Length(1,255);
            RuleFor(x => x.Family).NotNull();
            RuleFor(x => x.Address).NotNull();
            RuleFor(x => x.BirthDate).NotNull();
            RuleFor(x => x.BirthDate).LessThan("1401/01/01");
            RuleFor(x => x.Sex).NotNull();
            RuleFor(x=>x.NationalCode).NotNull();
            RuleFor(x => x.IdentityNumber).NotNull();
            RuleFor(x=>x.MobilNumber).NotNull();
        }
    }
}
