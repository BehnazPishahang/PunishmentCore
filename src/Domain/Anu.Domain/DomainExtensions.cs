using Microsoft.Extensions.DependencyInjection;

namespace Anu.Domain
{
    public static class DomainExtensions
    {
        public static void AddRepositories(this IServiceCollection serviceCollection, params System.Reflection.Assembly[] assemblies)
        {
            foreach (System.Reflection.Assembly assembly in assemblies)
            {
                AddAssemblyRepositories(assembly, serviceCollection);
            }
        }

        private static void AddAssemblyRepositories(System.Reflection.Assembly assembly, IServiceCollection serviceCollection)
        {

            foreach (Type repositoryClass in assembly.GetTypes().Where(a => a.Name.Contains("Repository")))
            {
                if (repositoryClass.IsGenericType)
                {
                    continue;
                }

                if (repositoryClass.IsAssignableTo(typeof(IGenericRepository)))
                {
                    if (repositoryClass.IsClass)
                    {
                        var repositoryInterface = repositoryClass.GetInterfaces().Last();
                        serviceCollection.AddTransient(repositoryInterface, repositoryClass);
                    }
                }
            }



        }
    }
}
