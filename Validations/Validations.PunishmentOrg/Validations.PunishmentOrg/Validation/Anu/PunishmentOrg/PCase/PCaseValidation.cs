using Anu.PunishmentOrg.Case;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations.PunishmentOrg.Validation.Anu.PunishmentOrg
{
    public class PCaseValidation : AbstractValidation<PCase>
    {
        public override List<System.ComponentModel.DataAnnotations.ValidationResult> Execute(PCase entity)
        {
            var result = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            result.Add(new System.ComponentModel.DataAnnotations.ValidationResult("", new string[] { nameof(entity.ArchiveNo) }));
            return result;
        }

        public override bool NeedExecute()
        {
            return false;
        }
    }

    
}
