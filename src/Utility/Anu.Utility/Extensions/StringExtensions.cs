using Anu.Commons.ServiceModel.ServiceResponse;

namespace Utility.Extensions
{
    public static class StringExtensions
    {

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
    }
}
