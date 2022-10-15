using Anu.BaseInfo.ServiceModel.Attachment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.ServiceModel.Validation.Attachment
{
    public class GAttachmentContractValidator : BaseInfoServiceModelValidator<GAttachmentContract>
    {
        public GAttachmentContractValidator()
        {
            RuleFor(x => x.PathAndFileName).NotEmpty().WithMessage("مسیر ذخیره سازی نمی تواند خالی باشد.");
            RuleFor(x => x.FileExtension).NotEmpty().WithMessage("پسوند فایل نمی تواند خالی باشد.");
        }
    }
}
