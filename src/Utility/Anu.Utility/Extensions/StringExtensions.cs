using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace Anu.Utility.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        
        public static bool IsValidNationalCode(this string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode)) throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
            if (nationalCode.Length != 10) throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
            switch (nationalCode)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                    throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
                default:
                    int code = 0;
                    char ch;
                    for (int i = 0; i < 9; i++)
                    {
                        ch = nationalCode[i];
                        if (ch < '0') throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
                        if (ch > '9') throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);

                        int v = ch - 48;
                        code += v * (10 - i);
                    }
                    int r = code % 11;
                    if (r > 1) r = 11 - r;
                    ch = nationalCode[9];
                    if (r == (ch - 48)) return true;
                    break;
            }

            throw new AnuExceptions(AnuResult.NationalCode_Is_Not_Valid);
        }

        public static bool IsValidPassword(this string password)
        {
            var passwordNumberOfCharRegexPattern = new Regex(@".{8,}");
            if (!passwordNumberOfCharRegexPattern.IsMatch(password))
            {
                throw new AnuExceptions(AnuResult.Password_Less_Than_8_charachter);
            }

            var passwordNumberRegexPattern = new Regex("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,})$");
            if (!passwordNumberRegexPattern.IsMatch(password))// && !specialRegexChar.IsMatch(newPass))
            {
                throw new AnuExceptions(AnuResult.Password_Should_Contain_Digit_And_Latin);
            }

            return true;
        }

        public static string NormalizeTextChars(this string strText, bool persian2Arabic = true)
        {
            if (string.IsNullOrEmpty(strText)) return strText;
            char arabicKaf = (char)1603;
            char arabicYa = (char)1610;

            char persianKaf = (char)1705;
            char persianYa = (char)1740;

            if (persian2Arabic)
            {
                string result = strText.Replace(persianKaf, arabicKaf);
                result = result.Replace(persianYa, arabicYa);
                return result;
            }
            else
            {
                string result = strText.Replace(arabicKaf, persianKaf);
                result = result.Replace(arabicYa, persianYa);
                return result;
            }
        }

        public static string ToPersianDateString(this string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            string[] dateValues = value.Split('/');
            StringBuilder result = new StringBuilder();
            int day = System.Convert.ToInt32(dateValues[2]);
            switch (day)
            {
                case 3:
                    result.Append("سوم");
                    break;
                case 23:
                    result.Append("بیست و سوم");
                    break;
                case 30:
                    result.Append("سی ام");
                    break;
                default:
                    result.Append(day.ToPersianText()).Append("م");
                    break;
            }
            result.Append(" ");
            int moon = System.Convert.ToInt32(dateValues[1]);
            switch (moon)
            {
                case 1:
                    result.Append("فروردین");
                    break;
                case 2:
                    result.Append("اردیبهشت");
                    break;
                case 3:
                    result.Append("خرداد");
                    break;
                case 4:
                    result.Append("تیر");
                    break;
                case 5:
                    result.Append("مرداد");
                    break;
                case 6:
                    result.Append("شهریور");
                    break;
                case 7:
                    result.Append("مهر");
                    break;
                case 8:
                    result.Append("آبان");
                    break;
                case 9:
                    result.Append("آذر");
                    break;
                case 10:
                    result.Append("دی");
                    break;
                case 11:
                    result.Append("بهمن");
                    break;
                case 12:
                    result.Append("اسفند");
                    break;
            }
            result.Append(" ماه ");
            int year = System.Convert.ToInt32(dateValues[0]);
            result.Append(year.ToPersianText());



            return result.ToString();
        }

        public static bool IsDigit(this string value, int length = 0)
        {
            if (string.IsNullOrEmpty(value)) return false;
            if (length != 0 && value.Length != length) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i])) return false;
            }
            return true;
        }

        public static bool IsLetter(this string value, int length = 0)
        {
            if (string.IsNullOrEmpty(value)) return false;
            if (length != 0 && value.Length != length) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i])) return false;
            }
            return true;
        }

        public static bool IsText(this string value, int length = 0)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            if (length != 0 && value.Length != length) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsWhiteSpace(value[i])) continue;
                if (!char.IsLetter(value[i])) return false;
            }
            return true;
        }


        public static bool LessThan(this string self, string value)
        {
            if (self == null && value == null) return false;
            if (value == null) return false;
            if (self == null) return true;
            return self.CompareTo(value) < 0;
        }

        public static bool LessThanEqual(this string self, string value)
        {
            if (self == null && value == null) return true;
            if (value == null) return false;
            if (self == null) return true;
            return self.CompareTo(value) <= 0;
        }

        public static bool GreaterThan(this string self, string value)
        {
            if (self == null && value == null) return false;
            if (value == null) return true;
            if (self == null) return false;
            return self.CompareTo(value) > 0;
        }

        public static bool GreaterThanEqual(this string self, string value)
        {
            if (self == null && value == null) return true;
            if (value == null) return true;
            if (self == null) return false;
            return self.CompareTo(value) >= 0;
        }

        public static string ToRtf(this string value)
        {
            string text = "{\\rtf1\\fbidis\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset178 B Nazanin;}}\\viewkind4\\uc1\\lang1065\\f0\\fs28 " + value + "}0";
            text = text.Replace("\r\n", @"\par");
            text = text.Replace("\n", @"\par");
            var sb = new System.Text.StringBuilder();
            foreach (var c in text)
            {
                if (c <= 0x7f)
                    sb.Append(c);
                else if (c <= 0xFF)
                    sb.Append("\\'" + Convert.ToUInt32(c).ToString("X"));
                else
                    sb.Append("\\u" + Convert.ToUInt32(c) + "?");
            }
            return sb.ToString();

        }
        public static string ToUtf8(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            var buffer = System.Text.Encoding.UTF8.GetBytes(value);
            return System.Text.Encoding.UTF8.GetString(buffer);

        }

        public static string[] ToSmsParameters(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            string sms = value.Trim(' ', '*');
            string[] result = sms.Split('*');
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = result[i].Trim();
                if (!result[i].IsDigit()) return null;
            }
            return result;
        }

        public static T As<T>(this object value)
        {
            return (T)value;
        }

        public static IDictionary<string, object> GetPropertyValues(this object value)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            if (value != null)
            {
                System.Type type = value.GetType();
                if (!(type.IsValueType || type == typeof(string)))
                {
                    var properties = type.GetProperties();
                    foreach (var p in properties)
                    {
                        object v = p.GetValue(value, null);
                        result.Add(p.Name, v);
                    }
                }
            }

            return result;
        }


        public static string Compress(this string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            using (System.IO.Compression.DeflateStream zip = new System.IO.Compression.DeflateStream(ms, System.IO.Compression.CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            System.IO.MemoryStream outStream = new System.IO.MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        public static string Decompress(this string compressedText)
        {
            byte[] gzBuffer = Convert.FromBase64String(compressedText);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (System.IO.Compression.DeflateStream zip = new System.IO.Compression.DeflateStream(ms, System.IO.Compression.CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        public static bool IsValidLegalNationalCode(this string nationalCode)
        {
            if (nationalCode.Length != 11)
                return false;
            int checkDigit = nationalCode[10] - 48;
            int dgt10th = nationalCode[9] - 48;

            int calc1th = (nationalCode[0] - 48 + dgt10th + 2) * 29;
            int calc2th = (nationalCode[1] - 48 + dgt10th + 2) * 27;
            int calc3th = (nationalCode[2] - 48 + dgt10th + 2) * 23;
            int calc4th = (nationalCode[3] - 48 + dgt10th + 2) * 19;
            int calc5th = (nationalCode[4] - 48 + dgt10th + 2) * 17;
            int calc6th = (nationalCode[5] - 48 + dgt10th + 2) * 29;
            int calc7th = (nationalCode[6] - 48 + dgt10th + 2) * 27;
            int calc8th = (nationalCode[7] - 48 + dgt10th + 2) * 23;
            int calc9th = (nationalCode[8] - 48 + dgt10th + 2) * 19;
            int calc10th = (nationalCode[9] - 48 + dgt10th + 2) * 17;

            int getdigit = (calc1th + calc2th + calc3th + calc4th + calc5th + calc6th + calc7th + calc8th + calc9th + calc10th) % 11;
            if (getdigit > 9)
                getdigit = getdigit % 10;
            if (checkDigit == getdigit)
                return true;
            return false;
        }

        public static System.Guid ToGuid(this string guid)
        {
            return new System.Guid(guid);
        }


        #region Encode & Decode To Hex
        public static string EncodeToHex(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(value);
            return EncodeToHexInternal(buffer);
        }
        private static string EncodeToHexInternal(byte[] buffer)
        {
            StringBuilder hexValue = new StringBuilder();
            for (int index = 0; index < buffer.Length; index++)
            {
                byte b1 = buffer[index];
                byte b2 = (byte)(b1 >> 4);
                hexValue.Append(EncodeToHexInternal(b2));
                b2 = (byte)(b1 << 4);
                b2 = (byte)(b2 >> 4);
                hexValue.Append(EncodeToHexInternal(b2));
            }
            return hexValue.ToString();
        }

        private static char EncodeToHexInternal(byte value)
        {
            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return (char)(value + 48);
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
            }
            return 'Z';
        }

        public static string DecodeFromHex(this string encodedValue)
        {
            if (string.IsNullOrEmpty(encodedValue))
            {
                return encodedValue;
            }
            byte[] buffer = DecodeFromHexInternal(encodedValue);
            return System.Text.Encoding.UTF8.GetString(buffer);
        }

        private static byte[] DecodeFromHexInternal(string encodedValue)
        {
            byte[] buffer = new byte[encodedValue.Length >> 1];
            for (int i = 0, j = 0; i < encodedValue.Length; i += 2, j++)
            {
                char c1 = encodedValue[i];
                char c2 = encodedValue[i + 1];
                byte b1 = DecodeFromHexInternal(c1);
                byte b2 = DecodeFromHexInternal(c2);
                byte b = (byte)((b1 << 4) + b2);
                buffer[j] = b;

            }
            return buffer;
        }

        private static byte DecodeFromHexInternal(char hexChar)
        {
            switch (hexChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return (byte)(hexChar - 48);
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
            }
            return (byte)'Z';
        }

        #endregion Encode & Decode To Hex
    }
}
