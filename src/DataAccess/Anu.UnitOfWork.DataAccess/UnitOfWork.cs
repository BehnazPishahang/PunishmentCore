using Anu.DataAccess;

namespace Anu.UnitOfWork.DataAccess
{
    public partial class UnitOfWork : Anu.DataAccess.IUnitOfWork
    {
        private readonly Anu.DataAccess.ApplicationDbContext _context;
        private readonly IDependencyResolver _dependencyResolver;

        public UnitOfWork(Anu.DataAccess.ApplicationDbContext context, Anu.DataAccess.IDependencyResolver dependencyResolver)
        {
            _context = context;
            _dependencyResolver = dependencyResolver;
        }

        public int Complete()
        {
            ValidateContext();
            return _context.SaveChanges();
        }

        private void ValidateContext()
        {
            var entries = _context.ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Modified
                    || entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    var entity = entry.Entity;
                    var validatorType = typeof(FluentValidation.IValidator<>);
                    validatorType = validatorType.MakeGenericType(entity.GetType());
                    var validator = _dependencyResolver.Resolve(validatorType);
                    if (validator != null)
                    {

                        var method = validatorType.GetMethod("Validate");
                        var validateResult = (FluentValidation.Results.ValidationResult?)method?.Invoke(validator, new object[] { entity });
                    }
                }
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public object GetService(System.Type type)
        {
            return _dependencyResolver.Resolve(type);
        }

        public T GetService<T>(System.Type type)
        {
            return _dependencyResolver.Resolve<T>(type);
        }

        public TRepository Repositorey<TRepository>() where TRepository : Domain.IGenericRepository
        {
            if (!typeof(TRepository).IsInterface)
            {
                throw new ArgumentException("TRepository Is Not Valid Type");
            }

            return _dependencyResolver.Resolve<TRepository>(typeof(TRepository));
        }
    }
}
