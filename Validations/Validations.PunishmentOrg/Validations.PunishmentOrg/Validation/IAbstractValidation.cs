namespace Validations.PunishmentOrg.Validation
{
    public interface IAbstractValidation<TEntity> where TEntity : class
    {
        abstract List<System.ComponentModel.DataAnnotations.ValidationResult> Execute(TEntity entity);

        bool NeedExecute();
    }
}