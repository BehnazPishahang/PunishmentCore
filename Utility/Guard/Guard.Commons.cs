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

       
    }
}
