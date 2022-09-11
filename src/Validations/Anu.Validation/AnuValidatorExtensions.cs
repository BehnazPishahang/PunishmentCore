using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Validation
{
    public static class AnuValidatorExtensions
    {
        public static void AddValidators(this IServiceCollection serviceCollection, params System.Reflection.Assembly[] assemblies)
        {
            foreach (System.Reflection.Assembly assembly in assemblies)
            {
                AddAssemblyValidators(assembly, serviceCollection);
            }
        }

        private static void AddAssemblyValidators(System.Reflection.Assembly assembly, IServiceCollection serviceCollection)
        {
            foreach (Type validatorClass in assembly.GetTypes())
            {
                if (validatorClass.IsAbstract || validatorClass.IsGenericType)
                {
                    continue;
                }

                if (validatorClass.IsAssignableTo(typeof(FluentValidation.IValidator)))
                {
                    var vType = GetValidatorType(validatorClass);
                    if (vType != null)
                    {
                        serviceCollection.AddScoped(vType, validatorClass);
                    }
                }
            }
        }

        private static System.Type? GetValidatorType(System.Type type)
        {
            if (type.IsGenericType)
            {
                var entityType = type.GenericTypeArguments[0];
                var returnType = typeof(FluentValidation.IValidator<>);
                return returnType.MakeGenericType(entityType);
            }
            else
            {
                if (type.BaseType != null)
                {
                    return GetValidatorType(type.BaseType);
                }
                return null;
            }
        }

    }
}
