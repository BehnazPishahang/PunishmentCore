
namespace Anu.PunishmentOrg.Validation
{
    public class PCaseValidation : AbstractValidation<Anu.PunishmentOrg.DataModel.Case.PCase>
    {
        public override List<System.ComponentModel.DataAnnotations.ValidationResult> Execute(Anu.PunishmentOrg.DataModel.Case.PCase entity)
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
