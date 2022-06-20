using ServiceModel.Commons.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace Utility.Guard
{
    public static class Commons
    {
        public static T Null<T>(this T input, ResultType type)
        {
            if (input is null)
            {
                throw new AnuExceptions(type);
            }

            return input;
        }

        public static string NullOrEmpty(this string? input, ResultType type)
        {
            input.Null(type);
            if (input == string.Empty)
            {
                throw new AnuExceptions(type);
            }

            return input;
        }

        public static Guid NullOrEmpty(this Guid? input, ResultType type)
        {
            input.Null(type);
            if (input == Guid.Empty)
            {
                throw new AnuExceptions(type);
            }

            return input.Value;
        }

        public static IEnumerable<T> NullOrEmpty<T>(this IEnumerable<T>? input, ResultType type)
        {
            input.Null(type);
            if (!input.Any())
            {
                throw new AnuExceptions(type);
            }

            return input;
        }

        public static string NullOrWhiteSpace(this string? input, ResultType type)
        {
            input.NullOrEmpty(type);
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new AnuExceptions(type);
            }

            return input;
        }

        public static T Default<T>(this T input, ResultType type)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)!) || input is null)
            {
                throw new AnuExceptions(type);
            }

            return input;
        }

        public static string IsDigit(this string value, ResultType type, int length = 0)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AnuExceptions(type);
            }
            if (length != 0 && value.Length != length)
            {
                throw new AnuExceptions(type);
            }
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    throw new AnuExceptions(type);
                }
            }
            return value;
        }


    }
}
