using FluentValidation;
using FluentValidation.Results;
using System.Collections.Concurrent;

namespace Anu.Validation
{
    public abstract class AnuValidator<T> : AbstractValidator<T>
    {
        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var r = base.Validate(context);
            var iv = AnuValidator.GetInternalValidatorIfExists(context.InstanceToValidate);
            if (iv != null)
            {
                var r1 = iv.Validate(context);
                r.Errors.AddRange(r1.Errors);
            }
            return r;
        }

        public override async Task<ValidationResult> ValidateAsync(ValidationContext<T> context, CancellationToken cancellation = default)
        {
            var r = await base.ValidateAsync(context, cancellation);
            var iv = AnuValidator.GetInternalValidatorIfExists(context.InstanceToValidate);
            if (iv != null)
            {
                var r1 = await iv.ValidateAsync(context, cancellation);
                r.Errors.AddRange(r1.Errors);
            }
            return r;
        }

    }

    public sealed class AnuValidator : AnuValidator<object>
    {
        private AnuValidator()
        {

        }

        private static readonly ConcurrentDictionary<System.Type, List<object>> _validators =
            new ConcurrentDictionary<Type, List<object>>();
        internal static InternalValidator<T>? GetInternalValidatorIfExists<T>(T instance)
        {
            var type = typeof(T);
            if (_validators.ContainsKey(type))
            {
                var validator = new InternalValidator<T>();
                var list = _validators[type];
                for (int i = 0; i < list.Count; i++)
                {
                    var item = (Action<T, AnuValidator<T>>)list[i];
                    item.Invoke(instance, validator);
                }
                return validator;
            }
            return null;
        }
        public static void RegisterValidator<T>(Action<T, AnuValidator<T>> validator)
        {
            var type = typeof(T);
            if (!_validators.ContainsKey(type))
            {
                _validators[type] = new List<object>();
            }
            var list = _validators[type];
            if (!list.Contains(validator))
            {
                list.Add(validator);
            }
        }
    }

    internal class InternalValidator<T> : AnuValidator<T>
    {

    }



}