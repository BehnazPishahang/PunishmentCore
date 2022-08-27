using Anu.BaseInfo.ServiceModel.Attachment;
using Anu.BaseInfo.ServiceModel.Types;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text;

namespace Anu.PunishmentOrg.ApiSample.PBillStore
{
    internal class RecieveGravamenSample
    {
        public RecieveGravamenSample()
        {

        }

        #region Create Json And Call Related WebApi
        public void Send()
        {
            var p1 = new PGravamenPersonContract()
        {

            Name = "Ali",
            Family = "Pooyan",
            Address = "Azadi St.",
            BirthDate = "1370/02/25",
            FatherName = "Hamid",
            IdentityNumber = "1234567895",
            MobilNumber = "09101112233",
            NationalCode = "1234567895",
            Nationality = Anu.BaseInfo.Enumerations.LNationality.Iranian,
            PersonStartPost = Enumerations.PUPersonStartPost.PlaintiffPerson,
            Sex = Anu.BaseInfo.Enumerations.SexType.Male,
            PersonType = Anu.BaseInfo.Enumerations.PersonType.NaturalPerson,
            PostCode = "",
            TradeUnitName = "",
            PersonPassword = "",
        };
        var p2 = new PGravamenPersonContract()
        {

            Name = "Haj Nemat",
            Family = "",
            Address = "",
            BirthDate = "",
            FatherName = "",
            IdentityNumber = "",
            MobilNumber = "",
            NationalCode = "",
            Nationality = Anu.BaseInfo.Enumerations.LNationality.Iranian,
            PersonStartPost = Enumerations.PUPersonStartPost.OffendingPerson,
            Sex = Anu.BaseInfo.Enumerations.SexType.Male,
            PersonType = Anu.BaseInfo.Enumerations.PersonType.NaturalPerson,
            PostCode = "",
            TradeUnitName = "Nanvaii Haj Nemat",
            PersonPassword = "",
        };

        var v = new PGravamenViolationContract()
        {

            RowNumber = 1,
            SubjectTitle = "Geran Forooshi",
            ViolationAddress = "Azadi St.",
            ViolationDate = "1401/06/02",
            ViolationDesc = "Geran Forooshi Ba Tozihat",
            ViolationPrice = 10000,
        };

        var a = new DataModel.Gravamen.PGravamenAttachment()
        {
            FileExtension = Anu.BaseInfo.Enumerations.FileExtension.PDF,
            TheAttachmentType = new Anu.BaseInfo.DataModel.Types.AttachmentType()
            {
                Code = "300",
                Id = "300",
                Title = "پيوست شكوائيه مردمي",
                Timestamp = 1
            },
            TheGAttachmentData = new Anu.BaseInfo.DataModel.Attachment.GAttachmentData()
            {
                DocFile = Encoding.ASCII.GetBytes("QW51IGNvcG9yYXRpb24=")
            }
        };

        var gravamen = new PGravamenContract()
        {

            PetitionSubject = "Petition Subject",
            PetitionDescription = "Petition Description",
            NoticeText = "Notice Text",
            PetitionReasons = "PetitionReasons",
            RejectReasonText = "Reject Reason Text",
            ReporterName = "Ali",
            ReporterFamily = "Pooyan",
            ReporterMobilNumber = "09101112233",
            
            ThePGravamenPersonContractList = new List<PGravamenPersonContract>() { p1, p2 },
            //TheGAttachmentContractList = (new List<DataModel.Gravamen.PGravamenAttachment>() { a }),
            ThePGravamenViolationContractList = new List<PGravamenViolationContract>() { v },

            CreateDateTime = "1401/02/06",
            FollowUpNo = "9995541",
            HowDataType = Enumerations.PU135OrWebSite.WebSite,
            GravamenOrReport = Anu.PunishmentOrg.Enumerations.GravamenOrReport.Gravamen,
        };



            var url = "http://localhost:93/SendPDiscoveryMinutesState";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(gravamen, Formatting.Indented);

            SaveJsonFileByCodeFile(json);

            var pBillStoreResult = this.CallApi<ReceivePBillStoreFromScmsRequest>(url, gravamen);



        }


        #endregion

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



        public class ReceivePBillStoreFromScmsRequest : PBillStoreFromScms, IRequestMessage
        {
            public Request Request { get; set; }

            public ReceivePBillStoreFromScmsRequest()
            {
                Request = new Request();
            }
        }

        [System.ComponentModel.DisplayName("ورودي سرويس قبض انبار از سامانه سمپق")]
        public class PBillStoreFromScms
        {
            public PBillStoreFromScms()
            {

            }

            [System.ComponentModel.DisplayName("تاريخ قبض")]
            public string BillDate { get; set; }


            [System.ComponentModel.DisplayName("شماره قبض انبار")]
            public string BillNumber { get; set; }


            [System.ComponentModel.DisplayName("کدينگ دستگاه کاشف")]
            public string CodingDeviceDetector { get; set; }


            [System.ComponentModel.DisplayName("شناسه يکتاي پرونده")]
            public string ParentContentNumber { get; set; }


            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("کلمه عبور")]
            public string PassWord { get; set; }


            [System.ComponentModel.DisplayName("شماره صورتجلسه")]
            public string ProceedingNumber { get; set; }


            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
            public List<PBillStorePersonScms> ThePBillStorePersonScmsList { get; set; }

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("خروجي کالا/ارز قبض/رسيد کالا/ارز صادر شده")]
            public List<PBillStoreProduct> ThePBillStoreProductList { get; set; }


            [System.ComponentModel.DisplayName("شناسه سامانه جامع انبارها")]
            public string TrackingCodeStores { get; set; }


            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نام کاربري")]
            public string UserName { get; set; }

        }

        [System.ComponentModel.DisplayName("اشخاص قبض انبار")]
        public class PBillStorePersonScms
        {

            [System.ComponentModel.DisplayName("نام پدر")]
            public string FatherName { get; set; }


            [System.ComponentModel.DisplayName("نام")]
            public string Fname { get; set; }


            [System.ComponentModel.DisplayName("نام خانوادگي")]
            public string Lname { get; set; }


            [System.ComponentModel.DisplayName("کد ملي")]
            public string NationalCode { get; set; }


            [System.ComponentModel.DisplayName("نوع شخص")]
            public long? PersonTypeId { get; set; }


            [System.ComponentModel.DisplayName("نام نقش")]
            public string RoleNameEN { get; set; }

            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس صورتجلسه کشف")]
            public PBillStoreFromScms ThePDiscoveryMinutes { get; set; }

        }


        [System.ComponentModel.DisplayName("کالای قبض انبار")]
        public class PBillStoreProduct
        {
            public string IDNumber { get; set; }
            public string ProductTitle { get; set; }
            public string ProductDesc { get; set; }
            public string PackingType { get; set; }
        }

        #endregion

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

        public class ReceivePBillStoreFromScmsResponse : PBillStoreFromScms, IResponseMessage
        {
            public Result Result { get; set; }
            public ReceivePBillStoreFromScmsResponse()
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
            var currentNamespace = typeof(ReceivePBillStoreFromScmsSample).Namespace;

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
