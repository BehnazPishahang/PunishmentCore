using System.Net.Http.Json;

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

        public static async Task<T> CallApi<T>(this string apiUrl, object value)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    var w = client.PostAsJsonAsync(apiUrl, value);
                    w.Wait();
                    HttpResponseMessage response = w.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("test");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return default(T);
        }


    }
}
