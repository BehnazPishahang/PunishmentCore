namespace Anu.PunishmentOrg.Validation.Case
{
    public class PCaseValidation : AbstractValidation<DataModel.Case.PCase>
    {
        public override List<System.ComponentModel.DataAnnotations.ValidationResult> Execute(DataModel.Case.PCase entity)
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
