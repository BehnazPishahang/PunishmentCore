using Anu.Commons.ServiceModel.ServiceResponse;
using Utility.Exceptions;

namespace Utility.Guard
{
    public static class Commons
    {
        public static T Null<T>(this T input, Enum type, string args = null)
        {
            if (input is null)
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static bool Null<T>(this T input)
        {
            if (input is null)
            {
                return false;
            }

            return true;
        }

        public static string NullOrEmpty(this string? input, Enum type, string args = null)
        {
            input.Null(type);
            if (input == string.Empty)
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static bool NullOrEmpty(this string? input)
        {
            if (!input.Null())
            {
                return false;
            }
            
            if (input == string.Empty)
            {
                return false;
            }

            return true;
        }

        public static Guid NullOrEmpty(this Guid? input, Enum type, string args = null)
        {
            input.Null(type);
            if (input == Guid.Empty)
            {
                throw new AnuExceptions(type, args);
            }

            return input.Value;
        }

        public static IEnumerable<T> NullOrEmpty<T>(this IEnumerable<T>? input, Enum type, string args = null)
        {
            input.Null(type);
            if (!input.Any())
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static string NullOrWhiteSpace(this string? input, Enum type, string args = null)
        {
            input.NullOrEmpty(type);
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static bool NullOrWhiteSpace(this string? input)
        {
            if (!input.NullOrEmpty())
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            return true;
        }


        public static T Default<T>(this T input, Enum type, string args = null)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)!) || input is null)
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static string IsDigit(this string value, Enum type, int length = 0, string args = null)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AnuExceptions(type, args);
            }
            if (length != 0 && value.Length != length)
            {
                throw new AnuExceptions(type, args);
            }
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    throw new AnuExceptions(type, args);
                }
            }
            return value;
        }


    }
}
