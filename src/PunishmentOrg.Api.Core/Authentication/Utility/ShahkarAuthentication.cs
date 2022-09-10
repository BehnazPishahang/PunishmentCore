using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility;
using System.Globalization;
using System.Text;
using Utility;
using Utility.Exceptions;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class ShahkarAuthentication
    {

        public static async Task<Result> ShahkarAuthenticate(string phoneNumber, string nationalCode)
        {
            if (Anu.Utility.Utility.IsDevelopment())
            {
                return AnuResult.Successful.GetResult();
            }

            string url = "https://gsbservices.iran.gov.ir/sazmantanzim/shahkar/ServiceIDmatching";

            string username = "tazirat_gsb";
            string password = "7@2irAt&96#%";
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Basic " + svcCredentials);
            headers.Add("ext_username", "tazirat_gsb");
            headers.Add("ext_password", "T@zi#rAt$%198");


            ShahKarRequest request = new ShahKarRequest();

            StringBuilder RequestId = new StringBuilder();
            RequestId.AppendFormat("{0}", "0644");
            RequestId.Append(DateTime.Now.ToString("yyyyMMddHHmmssffffff", CultureInfo.InvariantCulture));

            request.requestId = RequestId.ToString();
            request.serviceNumber = phoneNumber;
            request.serviceType = 2;
            request.identificationType = 0;
            request.identificationNo = nationalCode;

            var Result = (await url.CallApi(request, AnuResult.Shahkar_Unkhown_Error, authorization: null, headers = headers)).JsonDeserialize<ShahkarResponse>();

            switch (Result.response)
            {
                case 330:
                case 500:
                case 0:
                    throw new AnuExceptions(AnuResult.Shahkar_Could_Not_Inquiry, args: nationalCode);
                    break;
                case 600:
                    throw new AnuExceptions(AnuResult.Shahkar_NationalCode_PhoneNumber_Is_Not_Match, args: nationalCode);
                    break;
                case 311:
                    throw new AnuExceptions(AnuResult.Shahkar_NationalCode_PhoneNumber_Is_Not_Valid, args: nationalCode);
                    break;
                case 200:
                    return AnuResult.Successful.GetResult();
                    break;
                default:
                    throw new AnuExceptions(AnuResult.Shahkar_Unkhown_Error);
                    break;
            }
        }
    }
}



public class ShahKarRequest
{
    public string requestId { get; set; }
    public string serviceNumber { get; set; }
    public int serviceType { get; set; }
    public int identificationType { get; set; }
    public string identificationNo { get; set; }
}


public class ShahkarResponse
{
    public string result { get; set; }
    public string requestId { get; set; }
    public int response { get; set; }
    public string comment { get; set; }
    public object id { get; set; }
}

