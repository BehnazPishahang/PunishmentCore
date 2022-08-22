using SmsMagfa;
using System.Net;
using System.ServiceModel;

namespace Anu.SmsMagfa.Utility.Sms
{
    public static class SmsSender
    {
        public static async Task SendSms(string message)
        {




            //System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();
            //binding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
            //binding.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Basic;
            //binding.Security.Transport.ProxyCredentialType = System.ServiceModel.HttpProxyCredentialType.None;



            //System.ServiceModel.EndpointAddress endpointAddress = new System.ServiceModel.EndpointAddress("https://sms.magfa.com/services/urn:SOAPSmsQueue");

            // Credentials
            string password = "BIeJIGKBzNvMHAa4";
            string domain = "magfa";
            string username = "tazir_org" + "/" + domain;
            string url = "https://sms.magfa.com/api/soap/sms/v2/server?wsdl";

            MagfaSoapServerClient client = new MagfaSoapServerClient(url, new TimeSpan(0, 0, 30), username, password);//binding, endpointAddress);

            //client.ChannelFactory.Credentials.UserName.UserName = username + "/" + domain;
            //client.ChannelFactory.Credentials.UserName.Password = password;

            //NetworkCredential netCredential = new NetworkCredential(username + "/" + domain, password);
            //Uri uri = new Uri(url);
            //ICredentials credentials = netCredential.GetCredential(uri, "Basic");

            //client.ChannelFactory.Credentials.Windows.ClientCredential = netCredential;
            //client.ClientCredentials.Windows.ClientCredential = netCredential;


            // Call
            var result = await client.sendAsync(
                new string[] { "تست ارسال پيامک. Sample Text for test."},
                new string[] { "300000135" },
                new string[] { "09383623312" },
                null,
                null,
                null,
                null
            );

            //long[] result = await client.sendAsync(new string[] { "سلام" }, new string[] { "300000135" }, new string[] { "09194959257" }, null, null, null, null);

        }

       

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(TimeSpan timeout)
        {
            var httpsBinding = new BasicHttpsBinding();
            httpsBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            httpsBinding.Security.Mode = BasicHttpsSecurityMode.Transport;

            var integerMaxValue = int.MaxValue;
            httpsBinding.MaxBufferSize = integerMaxValue;
            httpsBinding.MaxReceivedMessageSize = integerMaxValue;
            httpsBinding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            httpsBinding.AllowCookies = true;

            httpsBinding.ReceiveTimeout = timeout;
            httpsBinding.SendTimeout = timeout;
            httpsBinding.OpenTimeout = timeout;
            httpsBinding.CloseTimeout = timeout;

            return httpsBinding;
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(string endpointUrl)
        {
            if (!endpointUrl.StartsWith("https://"))
            {
                throw new UriFormatException("The endpoint URL must start with https://.");
            }
            return new System.ServiceModel.EndpointAddress(endpointUrl);
        }
    }
}
