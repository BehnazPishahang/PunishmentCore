namespace Anu.Utility
{
    public static class Utility
    {

        public static int ToInt(this string text)
        {
            int result;

            if(text == null || text.Length == 0 || text.Equals(""))
                result = 0;
            else
                result = Convert.ToInt32(text);

            return result;
        }

        public static string GetRandomNumber(int length)
        {
            string AllowChars = "0123456789";
            var chars = new char[length];
            Random random = new();
            for (int i = 0; i < length; i++)
            {
                chars[i] = AllowChars[random.Next(0, AllowChars.Length)];
            }

            return new string(chars);
        }

    }
}
