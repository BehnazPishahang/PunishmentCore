using Anu.PunishmentOrg.Enumerations;
using FluentValidation;

namespace Anu.PunishmentOrg.Validation.PGravamen;

public partial class PGravamenValidator
{
    public PGravamenValidator()
    {
        ClassLevelCascadeMode = CascadeMode.Stop;

        RuleFor(p => p.PetitionSubject).NotNull().NotEmpty().WithMessage("موضوع شکایت نباید خالی باشد").WithErrorCode("-30221").WithSeverity(Severity.Error);
        RuleFor(p => p.PetitionDescription).NotNull().NotEmpty().WithMessage("شرح شکایت نباید خالی باشد").WithErrorCode("-30221").WithSeverity(Severity.Error);
        RuleFor(p => p.ThePGravamenAttachmentList).NotNull().NotEmpty().WithMessage("لیست فایل های الصاقی نباید خالی باشد").WithErrorCode("-30226").WithSeverity(Severity.Error);

        RuleFor(p => p.ThePGravamenPersonList).NotNull().NotEmpty().WithMessage("لیست افراد نباید خالی باشد").WithErrorCode("-30221").WithSeverity(Severity.Error).Custom((list, context) =>
        {
            bool[] availablePositions = new bool[2];
            var plaintiffIndex = 0;
            var offendingIndex = 1;

            foreach (var person in list!)
            {
                if (person.PersonStartPost == PUPersonStartPost.PlaintiffPerson)
                {
                    RuleForEach(p => p.ThePGravamenPersonList).ChildRules(child =>
                    {
                        child.RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("نام شاکی باید وارد شود");
                        child.RuleFor(c => c.Family).NotNull().NotEmpty().WithMessage("فامیل شاکی باید وارد شود");
                        child.RuleFor(c => c.BirthDate).NotNull().NotEmpty().WithMessage("تاریخ تولد شاکی باید وارد شود");
                        child.RuleFor(c => c.NationalCode).NotNull().NotEmpty().WithMessage("کد ملی شاکی باید وارد شود");
                        child.RuleFor(c => c.MobilNumber).NotNull().NotEmpty().WithMessage("شماره تلفن همراه شاکی باید وارد شود");
                        child.RuleFor(c => c.Sex).NotNull().NotEmpty().WithMessage("جنسیت شاکی باید وارد شود");
                        child.RuleFor(c => c.Address).NotNull().NotEmpty().WithMessage("آدرس شاکی باید وارد شود");
                    });


                    availablePositions[plaintiffIndex] = true;
                }
                if (person.PersonStartPost == PUPersonStartPost.OffendingPerson)
                {
                    RuleForEach(p => p.ThePGravamenPersonList).ChildRules(child =>
                    {
                        child.RuleFor(c => c.TradeUnitName).NotNull().NotEmpty().WithMessage("نام واحد تجاری متخلف باید وارد شود");
                        child.RuleFor(c => c.Address).NotNull().NotEmpty().WithMessage("آدرس متخلف باید وارد شود");
                    });

                    availablePositions[offendingIndex] = true;
                }
            }
            if (!availablePositions[plaintiffIndex] || !availablePositions[offendingIndex])
            {
                context.AddFailure("یکی از نقش های ضروری افراد خالی است - شاکی/متخلف");
            }
        });

        RuleForEach(p=>p.ThePGravamenAttachmentList).NotNull().WithMessage("لیست فایل های الصاق شده خالی است!");
        RuleForEach(p => p.ThePGravamenAttachmentList).ChildRules(child =>
        {
            child.RuleFor(c=>c.TheGAttachmentData).NotNull().WithMessage("هیچ فایلی الصاق نشده است");
            child.RuleFor(c=>c.TheGAttachmentData.DocFile).NotNull().WithMessage("فایل الصاق شده نامعتبر یا خالی است").WithErrorCode("-30227");
        });

    }


}