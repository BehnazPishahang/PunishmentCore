namespace Anu.PunishmentOrg.Api.Authentication
{
    public class DependencyResolver : Anu.DataAccess.IDependencyResolver
    {
        private IServiceProvider _serviceProvider;

        //public DependencyResolver(IServiceCollection serviceCollection)
        //{
        //    _serviceCollection = serviceCollection;
        //}

        public DependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object Resolve(Type type)
        {
            
            return _serviceProvider.GetService(type);
        }

        public T Resolve<T>(Type type)
        {
            return (T)Resolve(type);
        }
    }
}
