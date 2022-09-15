using Anu.BaseInfo.ServiceModel.ExchangeData;
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Anu.BaseInfo.ServiceModel.OrganizationChart;
using Anu.BaseInfo.ServiceModel.SystemConfiguration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ApiSample.BaseInfo.MechanizedLetter
{
    public class MechanizedLetterSample
    {
        #region Constructor
        public MechanizedLetterSample()
        {

        }
        #endregion

        #region Create Json And Call Related WebApi
        public void Send()
        {
            var OneMechanizedLetterRequest = new MechanizedLetterRequest()
            {

                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "creatorUserName",
                    LetterText = "تست",
                    OuterOrgLetterDate = "1398/04/01",
                    OuterOrgLetterNo = "3445",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract
                    {
                        Code = "00025"
                    },

                    TheGMechanizedLetterCaseContractList = new List<GMechanizedLetterCaseContract>()
                    {
                        new GMechanizedLetterCaseContract
                        {
                          RelatedCaseNo = "139400118012001925",
                          RelatedCaseTitle = "relatedCaseTitle",
                            TheUnitContract = new UnitContract()
                            {
                                Code= "18066"

                            }

                        }



                    },
                    TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
                    {
                        new GMechanizedLetterReceiverContract
                        {
                            MainRcvOrTranscriptRcv= Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv.MainReceiver,
                            ReceiverType= Anu.BaseInfo.Enumerations.MechanizeRefererType.Unit,
                            TheCMSOrganizationContract= new CMSOrganizationContract{
                              Code= "01141"
                              },
                              TheCMSUserRoleTypeContract= new CMSUserRoleTypeContract{
                              Code= "0006"
                              }
                        }


                    },
                    //TheGMechanizedLetterFieldsContractList = new List<GMechanizedLetterFieldsContract>()
                    //{

                    //},
                    TheGMechanizedLetterRelLettersContractList = new List<GMechanizedLetterRelLettersContract>()
                    {
                        new GMechanizedLetterRelLettersContract{
                            RelationType=Anu.BaseInfo.Enumerations.MechanizedLetterRelType.Follower,
                            RelLetterDate="1395/03/20",
                            RelLetterGetType= Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType.Mechanize,
                            RelLetterNo= "14019860300000021"

                        }
                    }


                }

            };

            var url = "http://localhost:93/api/v2/SendMechanizedLetter";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(OneMechanizedLetterRequest, Formatting.Indented);
            SaveJsonFileByCodeFile(json);
            var PDiscoveryMinutesStateResult = this.CallApi<MechanizedLetterRequest>(url, OneMechanizedLetterRequest);

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

        private static void SaveJsonFileByCodeFile(string json)
        {
            string path = GetCodeFilePath();

            GrantWriteAccess(path);

            File.WriteAllText(path + "/file.json", json);
        }

        private static string GetCodeFilePath()
        {
            var currentNamespace = typeof(MechanizedLetterSample).Namespace;

            var namespaceSections = currentNamespace.Split('.');

            var path = string.Format("../../../{0}/{1}/{2}/{3}/{4}", namespaceSections[0], namespaceSections[1], namespaceSections[2], namespaceSections[3], namespaceSections[4]);

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
