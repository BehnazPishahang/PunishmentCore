
namespace Anu.DataAccess
{
    public partial interface IUnitOfWork : IDisposable
    {
        TRepository Repositorey<TRepository>() where TRepository : Domain.IGenericRepository;

        int Complete();

        FluentValidation.Results.ValidationResult Validate();
    }
}
