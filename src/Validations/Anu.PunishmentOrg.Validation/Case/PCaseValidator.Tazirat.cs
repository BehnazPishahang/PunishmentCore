using FluentValidation;

namespace Anu.PunishmentOrg.Validation.Case
{
    public partial class PCaseValidator
    {
        public PCaseValidator()
        {
            /*
             * برای مطالعه بیشتر در مورد نوشتن راستی آزمایی ها به صفحات زیر مراجعه شود
             * 
             * https://docs.fluentvalidation.net/en/latest/
             * https://codewithmukesh.com/blog/fluent-validation-aspnet-core/
             * 
             */
            this.RuleFor(x => x.No)
                .Cascade(CascadeMode.Stop)/*اگر شرط اول برقرار نبود ادامه نمی دهید*/
                .NotNull()
                .WithMessage($"شماره مکانیزه نمی تواند خالی باشد")
                .Length(0, 20)
                .WithMessage($"شماره مکانیزه نمی تواند بیشتر از 10 کاراکتر باشد");


            this.RuleFor(x => x.ManualNo)
                .NotNull()
                .WithMessage($"شماره دستی نمی تواند خالی باشد");

            this.RuleFor(pcase => pcase.ManualNo)
                .NotEmpty()
                .When(pcase => pcase.SubNo.HasValue, ApplyConditionTo.CurrentValidator);

            this.When(pcase => pcase.ManualNo == null , () => 
            {
                this.RuleFor(pcase => pcase.ArchiveNo)
                    .Length(0, 10)
                    .WithMessage($"شماره بایگانی نمی تواند بیشتر از 10 کاراکتر باشد");
            }).Otherwise(() => {
                this.RuleFor(pcase => pcase.ArchiveNo)
                    .Length(0, 15)
                    .WithMessage($"شماره بایگانی نمی تواند بیشتر از 10 کاراکتر باشد");
            });

            this.RuleForEach(x => x.ThePArrestedList).ChildRules(onePArrested =>
            {
                onePArrested.RuleFor(thePArrested => thePArrested.No)
                            .NotEmpty()
                            .WithMessage($"شماره یکتای بازداشتی نمی تواند خالی باشد");
            });
        }
    }
}