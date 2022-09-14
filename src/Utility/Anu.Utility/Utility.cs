using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text;
using System.Xml.Serialization;
using Utility.Exceptions;

namespace Anu.Utility
{
    public static class Utility
    {
        public static string GetDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }

        public static string ToCompleteString(this System.Exception ex)
        {
            if (ex == null) return string.Empty;
            StringBuilder sb = new StringBuilder();
            System.Exception ex1 = ex;
            while (ex1 != null)
            {
                sb.Append("Message: ").Append(ex1.Message).AppendLine();
                sb.Append("Source: ").Append(ex1.Source).AppendLine();
                sb.Append("StackTrace: ").Append(ex1.StackTrace).AppendLine();
                sb.Append("----------------------------------------------------").AppendLine();
                ex1 = ex1.InnerException;

            }
            return sb.ToString();
        }

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

        public static string UTF8(this byte[] input)
        {
            return System.Text.Encoding.UTF8.GetString(input);
        }

        public static T XmlDeserialize<T>(this string content)
        {
            var serializer = new XmlSerializer(typeof(T));
            T result;

            using (TextReader reader = new StringReader(content))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }

        public static async Task<string> CallApi(this string apiUrl, object value,Enum errorIsFailedStatus, Dictionary<string, string> authorization = null, Dictionary<string, string> headers = null,bool IsJson=true)
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

                    HttpResponseMessage response;
                    if (IsJson)
                        response = await client.PostAsJsonAsync(apiUrl, value);
                    else
                    {
                        var httpContent = new StringContent(value.ToString(), Encoding.UTF8, "application/xml");
                        response = await client.PostAsync(apiUrl, httpContent);
                    }

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new AnuExceptions(errorIsFailedStatus);
                    }
                    return (await response.Content.ReadAsStringAsync()).Replace("'", "\"");

                }
            }
            catch (Exception ex)
            {
                throw new AnuExceptions(AnuResult.Error, ex);
            }
            return null;
        }

        public static string ConvertToBase64(this byte[] data)
        {
            return Convert.ToBase64String(data, 0, data.Length);
        }

        public static byte[] ConvertToByte(this string data)
        {
            return Convert.FromBase64String(data);
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

        public static bool IsDevelopment()
        {
            bool isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
            return isDevelopment;
        }
    }


}
