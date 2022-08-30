using Microsoft.Extensions.DependencyInjection;

namespace Anu.Domain
{
    public static class DomainExtensions
    {
        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            Dictionary<string, bool> assemblies = new Dictionary<string, bool>();
            foreach (System.Reflection.Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                AddAssemblyRepositories(assembly, assemblies, serviceCollection);
            }
        }

        private static void AddAssemblyRepositories(System.Reflection.Assembly assembly, Dictionary<string, bool> assemblies, IServiceCollection serviceCollection)
        {
            if (!assemblies.ContainsKey(assembly.FullName) && assembly.FullName.StartsWith("Anu."))
            {
                assemblies[assembly.FullName] = true;
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

                var referencedAssemblies = assembly.GetReferencedAssemblies();
                foreach (var referencedAssembly in referencedAssemblies)
                {
                    if (!assemblies.ContainsKey(referencedAssembly.FullName) &&  assembly.FullName.StartsWith("Anu."))
                    {
                        var asm = System.Reflection.Assembly.Load(referencedAssembly);
                        AddAssemblyRepositories(asm, assemblies, serviceCollection);
                    }
                }
            }
        }
    }
}
