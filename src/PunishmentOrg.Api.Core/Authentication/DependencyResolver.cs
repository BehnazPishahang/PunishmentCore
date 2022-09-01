namespace Anu.PunishmentOrg.Api.Authentication
{
    public class DependencyResolver : Anu.DataAccess.IDependencyResolver
    {
        private readonly IServiceCollection _serviceCollection;
        private IServiceProvider _serviceProvider;

        public DependencyResolver(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public object Resolve(Type type)
        {
            if (_serviceProvider is null)
            {
                _serviceProvider = _serviceCollection.BuildServiceProvider();
            }
            return _serviceProvider.GetService(type);
        }

        public T Resolve<T>(Type type)
        {
            return (T)Resolve(type);
        }
    }
}
