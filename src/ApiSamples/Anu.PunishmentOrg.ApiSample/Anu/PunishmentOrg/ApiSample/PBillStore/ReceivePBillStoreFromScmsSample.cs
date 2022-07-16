using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Anu.PunishmentOrg.ApiSample.PBillStore
{
    internal class ReceivePBillStoreFromScmsSample
    {
        public ReceivePBillStoreFromScmsSample()
        {

        }

        #region Create Json And Call Related WebApi
        public void Send()
        {
            ReceivePBillStoreFromScmsRequest request = new ReceivePBillStoreFromScmsRequest()
            {
                Request = new Request()
                {
                    UserName = "Service.SCMS",
                    PassWord = "123qweR",
                },

            };

            var apiPerson1 = new PBillStorePersonScms()
            {
                Fname = "Ali",
                Lname = "Salehi",
                NationalCode = "1234567899",
                FatherName = "Manoochehr",
                PersonTypeId = 1,
                RoleNameEN = "1"
            };
            var apiPerson2 = new PBillStorePersonScms()
            {
                Fname = "Saleh",
                Lname = "Alimi",
                NationalCode = "1234567899",
                FatherName = "Sahba",
                PersonTypeId = 2,
                RoleNameEN = "2"
            };

            var product1 = new PBillStoreProduct()
            {
                IDNumber = "111111111",
                ProductTitle = "گاز رو میزی",
                ProductDesc = "یک عدد گاز رو میزی سه شعله",
                PackingType = "ضربه گیر"
            };

            var pBillStore = new PBillStoreFromScms()
            {
                BillDate = "1401/01/01",
                BillNumber = "123456789101112",
                CodingDeviceDetector = "4",
                ParentContentNumber = "55",
                ProceedingNumber = "123456",
                TrackingCodeStores = "14245295169488",
                ThePBillStoreProductList = new List<PBillStoreProduct>()
                {
                    product1
                },
                ThePBillStorePersonScmsList = new List<PBillStorePersonScms>()
                {
                    apiPerson1,
                    apiPerson2
                },

                //Request =
                //{
                //    UserName = "Service.SCMS",
                //    PassWord = "123qweR",
                //}

            };


            var url = "http://localhost:93/SendPDiscoveryMinutesState";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(pBillStore, Formatting.Indented);

            var pBillStoreResult = this.CallApi<ReceivePBillStoreFromScmsRequest>(url, pBillStore);
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
    }
}
