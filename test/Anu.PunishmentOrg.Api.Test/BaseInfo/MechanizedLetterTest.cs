using Anu.BaseInfo.ServiceModel.ExchangeData;
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Anu.BaseInfo.ServiceModel.OrganizationChart;
using Anu.BaseInfo.ServiceModel.SystemConfiguration;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Api.BaseInfo;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.BaseInfo
{
    public class MechanizedLetterTest
    {
        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();

        private readonly MechanizedLetterServiceController controller;

        public MechanizedLetterTest()
        {
            controller = new MechanizedLetterServiceController(_unitOfWork.Object);
        }

        [Fact]
        public void MechanizedLetter_RequestIsNull_ShouldReturnRequestIsNullOrCorrupt()
        {
            //Arrange
            MechanizedLetterRequest request = null;

            //Act
            var result = controller.SendMechanizedLetter(request);

            //Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_Request_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public void RecieveMechanizedLetter_SuccessfullyExecuted_ShouldReturnSuccessfulResult()
        {
            //Arrange
            var request = new MechanizedLetterRequest()
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
                            TheunitContract = new unitContract
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

            //Act
            var result = controller.SendMechanizedLetter(request);

            //Assert
            Assert.Equal((int)AnuResult.Successful, result.Result.Result.Code);
        }

    }
}
