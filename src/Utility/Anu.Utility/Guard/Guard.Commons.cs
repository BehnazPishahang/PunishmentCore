using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using System.Text.RegularExpressions;
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
        public static string Length(this string? input, Enum type, int length, string args = null)
        {
            if (input.Length != length)
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static string IsMatch(this string? input, Enum type, Regex regex, string args = null)
        {
            if (!regex.IsMatch(input))
            {
                throw new AnuExceptions(type, args);
            }

            return input;
        }

        public static string IsValidNationalCode(this string nationalCode)
        {
            //در صورتی که کد ملی وارد شده تهی باشد
            nationalCode.NullOrEmpty(AnuResult.NationalCode_Is_Not_Valid);

            //در صورتی که کد ملی وارد شده طولش کمتر از 10 رقم باشد
            nationalCode.Length(AnuResult.NationalCode_Length_Is_Not_Valid, 10);

            //در صورتی که کد ملی ده رقم عددی نباشد
            var regex = new Regex(@"\d{10}");
            nationalCode.IsMatch(AnuResult.NationalCode_Must_Be_Number,regex);

            //در صورتی که رقم‌های کد ملی وارد شده یکسان باشد
            var allDigitEqual = new[] { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
            if (allDigitEqual.Contains(nationalCode))
            {
                nationalCode.NullOrEmpty(AnuResult.NationalCode_Is_Not_Valid);
            }

            var chArray = nationalCode.ToCharArray();
            var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;
            var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            var a = Convert.ToInt32(chArray[9].ToString());

            var b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
            var c = b % 11;

            if(!(((c < 2) && (a == c)) || ((c >= 2) && ((11 - c) == a))))
            {
                throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
            }

            return nationalCode;
        }

        public static string IsValidPhone(this string Phone)
        {
            Phone.NullOrEmpty(AnuResult.PhoneNumber_Is_Not_Entered);
            var r = new Regex(@"^(?:0|98|\+98|\+980|0098|098|00980)?(9\d{9})$");
            Phone.IsMatch(AnuResult.PhoneNumber_Is_Not_Valid, r);

            return Phone;
        }

        public enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        public class PasswordAdvisor
        {
            public static PasswordScore CheckStrength(string password)
            {
                int score = 0;

                if (password.Length < 1)
                    return PasswordScore.Blank;
                if (password.Length < 4)
                    return PasswordScore.VeryWeak;

                if (password.Length >= 8)
                    score++;
                if (password.Length >= 12)
                    score++;
                if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
                    score++;
                if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
                  Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                    score++;
                if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                    score++;

                return (PasswordScore)score;
            }
        }
    }
}
