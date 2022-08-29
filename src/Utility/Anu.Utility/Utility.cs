using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using Utility.Exceptions;

namespace Anu.Utility
{
    public static class Utility
    {

        public static int ToInt(this string text)
        {
            int result;

            if (text == null || text.Length == 0 || text.Equals(""))
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

        public static T To<T>(this object input, T defaultValue)
        {
            var result = defaultValue;

            if (input == null || input == DBNull.Value) return result;
            if (typeof(T).IsEnum)
            {
                result = (T)Enum.ToObject(typeof(T), To(input, Convert.ToInt32(defaultValue)));
            }
            else
            {
                result = (T)Convert.ChangeType(input, typeof(T));
            }


            return result;
        }

        public static T To<T>(this object input)
        {
            return To(input, default(T));
        }

        public static T JsonDeserialize<T>(this string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<string> CallApi(this string apiUrl, object value,Enum errorIsFailedStatus, Dictionary<string, string> authorization = null, Dictionary<string, string> headers = null)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Clear();

                    if (headers != null)
                    {
                        foreach (var header in headers)
                        {
                            client.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }

                    if (authorization != null)
                    {
                        client.DefaultRequestHeaders.Authorization = new BasicAuthenticationHeaderValue(authorization["Username"], authorization["Password"]);
                    }

                    var w = client.PostAsJsonAsync(apiUrl, value);
                    w.Wait();
                    HttpResponseMessage response = w.Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new AnuExceptions(errorIsFailedStatus);
                    }
                    return await response.Content.ReadAsStringAsync();

                }
            }
            catch (Exception ex)
            {
                throw new AnuExceptions(AnuResult.Error, ex);
            }
            return null;
        }


    }
}
