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

        public static string NullOrEmpty(this string? input, Enum type, string args = null)
        {
            input.Null(type);
            if (input == string.Empty)
            {
                throw new AnuExceptions(type, args);
            }

            return input;
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

        public static bool IsValidDate(this string? dateString, Enum type, string args = null)
        {
            if (string.IsNullOrEmpty(dateString))
            {
                throw new AnuExceptions(type, args);
            }

            bool blnTruncated = true;
            bool blnValid = true;

            dateString = dateString.Trim();

            if (dateString.Length == 10)
                blnTruncated = false;
            else if (dateString.Length == 8)
                blnTruncated = true;
            else
            {
                blnValid = false;
                throw new AnuExceptions(type, args);
            }

            if (blnValid)
            {
                int pos1 = dateString.IndexOf("/");

                if ((pos1 == 4 && !blnTruncated) || (pos1 == 2 && blnTruncated))
                {
                    int pos2 = dateString.IndexOf("/", pos1 + 1);
                    if ((pos2 == 7 && !blnTruncated) || (pos1 == 5 && blnTruncated))
                    {
                        string[] arrDateItems = dateString.Split('/');

                        int year = int.Parse(arrDateItems[0]);
                        int month = int.Parse(arrDateItems[1]);
                        int day = int.Parse(arrDateItems[2]);

                        if (blnTruncated)
                            year += 1300;

                        if (month <= 12 && month >= 1)
                        {
                            if (month < 7)
                                blnValid = (day <= 31 && day >= 1);
                            else if ((month < 12 && month >= 7) || (month == 12 && IsLeapYear(year)))
                                blnValid = (day <= 30 && day >= 1);
                            else
                                blnValid = (day <= 29 && day >= 1);

                        }
                        else
                        {
                            blnValid = false;
                            throw new AnuExceptions(type, args);
                        }

                    }
                    else
                    {
                        blnValid = false;
                        throw new AnuExceptions(type, args);
                    }
                }
                else
                {
                    blnValid = false;
                    throw new AnuExceptions(type, args);
                }
            }

            return blnValid;

        }

        public static bool IsLeapYear(int year)
        {
            int temp1, temp2;

            if (year == 474)
                return true;

            if (year < 474)
                temp1 = year + 42;
            else
                temp1 = year + 38;

            temp2 = (temp1 % 128);
            if (temp2 == 0)
                return true;

            if (temp2 <= 30)//main
            {
                if (((temp2 % 4) == 1) && (temp2 != 1))
                    return true;
            }
            else
            {
                if (temp2 <= 63) //2
                {
                    if ((temp2 % 4) == 2)
                        return true;
                }
                else
                {
                    if (temp2 <= 96) //3
                    {
                        if ((temp2 % 4) == 3)
                            return true;
                    }
                    else
                    {
                        if (temp2 > 30)
                        {
                            if ((temp2 % 4) == 0) return true;
                        }
                    }//else 3
                }//else 2
            }//if else main

            return false;


        }


    }
}
