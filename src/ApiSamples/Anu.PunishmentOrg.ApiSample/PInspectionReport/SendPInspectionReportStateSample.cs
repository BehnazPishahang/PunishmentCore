using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ApiSample.PInspectionReport
{
    public class SendPInspectionReportStateSample
    {

        #region Constructor
        public SendPInspectionReportStateSample()
        {

        }
        #endregion Constructor

        #region Create Json And Call Related WebApi
        public void Send()
        {
            SendPInspectionReportStateRequest sendPInspectionReportStateRequest = new SendPInspectionReportStateRequest()
            {
                Request = new Request() { UserName = "Service.Hemayat", PassWord = "1234" },
                UniqueNo = "139506330000000039"

            };

            var url = "http://localhost:7075/PInspectionReport/SendPInspectionReportState";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(sendPInspectionReportStateRequest, Formatting.Indented);
            SaveJsonFileByCodeFile(json);
            var PDiscoveryMinutesStateResult = this.CallApi<SendPInspectionReportStateRequest>(url, sendPInspectionReportStateRequest);

            Console.WriteLine("send");
        }
        #endregion Create Json And Call Related WebApi

        #region CallApi
        private async Task<T> CallApi<T>(string apiUrl, object value)
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
        #endregion CallApi

        #region Request Classes

        public interface IRequestMessage
        {
            Request Request { get; set; }
        }

        public interface IRequest
        {
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            string UserName { get; set; }

            [System.ComponentModel.DisplayName("کلمه عبور")]
            string PassWord { get; set; }
        }

        public class Request : IRequest
        {
            public Request()
            {
                this.UserName = "";
                this.PassWord = "";
            }
            public string UserName { get; set; }
            public string PassWord { get; set; }
        }



        public class SendPInspectionReportStateRequest : PInspectionResponse, IRequestMessage
        {
            public Request Request { get; set; }

            public SendPInspectionReportStateRequest()
            {
                Request = new Request();
            }
        }

        [System.ComponentModel.DisplayName("خروجي سرويس گزارش بازرسي")]
        public class PInspectionResponse
        {
            public PInspectionResponse()
            {
            }


            [System.ComponentModel.DisplayName("ساعت خاتمه جلسه رسيدگي")]
            public string? EndTime { get; set; }


            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string? PassWord { get; set; }



            [System.ComponentModel.DisplayName("تاريخ وقت")]
            public string? RegisterDate { get; set; }



            [System.ComponentModel.DisplayName("وضعيت تجديد نظر")]
            public string? RevisionRequest { get; set; }



            [System.ComponentModel.DisplayName("ساعت شروع جلسه رسيدگي")]
            public string? StartTime { get; set; }



            [System.ComponentModel.DisplayName("شناسه يکتا")]
            public string? UniqueNo { get; set; }



            [System.ComponentModel.DisplayName("نام واحد")]
            public string? UnitName { get; set; }



            [System.ComponentModel.DisplayName("شماره واحد رسيدگي کننده")]
            public string? UnitNo { get; set; }



            [System.ComponentModel.DisplayName("نام کاربري")]
            public string? UserName { get; set; }


        }

        #endregion Request Classes

        #region Response Classes
        public interface IResult
        {
            string Message { get; set; }
            string Description { get; set; }
            string Code { get; set; }
        }

        public class Result : IResult
        {
            public Result()
            {
                this.Message = "";
                this.Description = "";
                this.Code = "";
            }
            public string Message { get; set; }
            public string Description { get; set; }
            public string Code { get; set; }
        }

        public interface IResponseMessage
        {
            Result Result { get; set; }
        }

        public class SendPInspectionReportStateResponse : PInspectionResponse, IResponseMessage
        {
            public Result Result { get; set; }
            public SendPInspectionReportStateResponse()
            {
                Result = new Result();
            }
        }

        #endregion Response Classes



        private static void SaveJsonFileByCodeFile(string json)
        {
            string path = GetCodeFilePath();

            GrantWriteAccess(path);

            File.WriteAllText(path + "/file.json", json);
        }
        private static string GetCodeFilePath()
        {
            var currentNamespace = typeof(SendPInspectionReportStateSample).Namespace;

            var namespaceSections = currentNamespace.Split('.');

            var path = string.Format("../../../{0}/{1}/{2}/{3}", namespaceSections[0], namespaceSections[1], namespaceSections[2], namespaceSections[3]);

            return path;
        }
        private static void GrantWriteAccess(string path)
        {
            var username = Environment.UserName;
            var directoryInfo = new DirectoryInfo(path);
            var directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
            directoryInfo.Attributes &= ~FileAttributes.ReadOnly;
            directoryInfo.SetAccessControl(directorySecurity);
        }

    }
}
