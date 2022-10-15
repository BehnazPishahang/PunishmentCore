using Anu.BaseInfo.DataAccess.ExchangeData;
using Anu.BaseInfo.DataAccess.GMechanizedLetter;
using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.DataModel.MechanizedLetter;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.BaseInfo.ServiceModel.ExchangeData;
using Anu.BaseInfo.ServiceModel.MechanizedLetter;
using Anu.BaseInfo.ServiceModel.OrganizationChart;
using Anu.BaseInfo.ServiceModel.SystemConfiguration;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Api.BaseInfo.MechanizedLetter;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.BaseInfo.MechanizedLetter
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
        public async Task MechanizedLetter_RequestIsNull_ShouldReturnRequestIsNullOrCorrupt()
        {

            //Arrange

            MechanizedLetterRequest request = null;

            //Act
            var result = await controller.SendMechanizedLetter(request);

            //Assert

            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_Request_Is_Null, result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_GMechanizedLetterTypeCodeIsNull_ShouldReturnGMechanizedLetterTypeCode_IsNull()
        {
            //Arrange
            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = ""
                    }
                }
            };

            //Act
            var result = controller.SendMechanizedLetter(request);

            //Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_GMechanizedLetterTypeCode_Is_null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_GMechanizedLetterTypeCodeIsNotValid_ShouldReturnGMechanizedLetterTypeCode_IsNotValid()
        {
            //Arrange

            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
             .ReturnsAsync((GMechanizedLetterType)null);

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "0002999"
                    }
                }
            };

            //Act
            var result = controller.SendMechanizedLetter(request);

            //Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_GMechanizedLetterTypeCode_Is_Not_Valid, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_CreatorUserNameISNull_ShouldReturnMechanizedLetter_CreatorUserName_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_CreatorUserName_Is_Null, result.Result.Result.Code);
        }


        [Fact]
        public async Task MechanizedLetter_TheNAJAUnitContractCodeISNull_ShouldReturnMechanizedLetter_NAJAUnit_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync((NAJAUnit)null);

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = ""
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_NAJAUnit_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_TheNAJAUnitContractCodeISNotValid_ShouldReturnMechanizedLetter_NAJAUnit_IsNotValid()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync((NAJAUnit)null);

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "1111111"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_SenderOuterOrgCode_Is_Not_Valid, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_OuterOrgLetterDateIsNull_ShouldReturnMechanizedLetter_OuterOrgLetterDate_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_OuterOrgLetterDateIsNotValid_ShouldReturnMechanizedLetter_OuterOrgLetterDate_IsNotValid()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_OuterOrgLetterDate_Is_Not_ValidDate, result.Result.Result.Code);
        }


        [Fact]
        public async Task MechanizedLetter_OuterOrgLetterNoIsNull_ShouldReturnMechanizedLetter_OuterOrgLetterNo_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_OuterOrgLetterNoIsNotDigit_ShouldReturnMechanizedLetter_OuterOrgLetterNo_IsNotDigit()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "x",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_OuterOrgLetterNo_Is_Not_Digit, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_TheGMechanizedLetterReceiverLIstIsNull_ShouldReturnMechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "3445",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    },
                    TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
                    {

                    }
                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_RecieveGMechanizedLetterServiceResult_Reciver_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_MainRcvOrTranscriptRcvIsNull_ShouldReturnMechanizedLetter_mainRcvOrTranscriptRcv_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "3445",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    },
                    TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
                    {
                        new GMechanizedLetterReceiverContract()
                        {
                            MainRcvOrTranscriptRcv=null
                        }
                    }

                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_mainRcvOrTranscriptRcv_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_ReceiverTypeIsNull_ShouldReturnMechanizedLetter_ReceiverType_IsNull()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "3445",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    },
                    TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
                    {
                        new GMechanizedLetterReceiverContract()
                        {
                            MainRcvOrTranscriptRcv=Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv.MainReceiver,
                            ReceiverType=null
                        }
                    }

                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_ReceiverType_Is_Null, result.Result.Result.Code);
        }

        [Fact]
        public async Task MechanizedLetter_MainRcvOrTranscriptRcvIsNotValid_ShouldReturnMechanizedLetter_mainRcvOrTranscriptRcv_IsNNotValid()
        {
            // Arrange
            _unitOfWork.Setup(setup => setup.Repositorey<IGMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
            .ReturnsAsync(new GMechanizedLetterType()
            {
                Code = "00027"
            });

            _unitOfWork.Setup(setup => setup.Repositorey<INAJAUnitRepository>().GetByCode(It.IsAny<string>())).
                ReturnsAsync(new NAJAUnit()
                {
                    Code = "00001"
                });

            MechanizedLetterRequest request = new MechanizedLetterRequest()
            {
                TheGMechanizedLetterContract = new GMechanizedLetterContract()
                {
                    CreatorUserName = "CreatorUserName",
                    OuterOrgLetterDate = "1401/06/01",
                    OuterOrgLetterNo = "3445",
                    TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract()
                    {
                        Code = "00027"
                    },
                    TheNAJAUnitContract = new NAJAUnitContract()
                    {
                        Code = "00001"
                    },
                    TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
                    {
                        new GMechanizedLetterReceiverContract()
                        {
                            MainRcvOrTranscriptRcv=(Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv)8,
                            ReceiverType=Anu.BaseInfo.Enumerations.MechanizeRefererType.Unit
                        }
                    }

                }
            };
            // Act
            var result = controller.SendMechanizedLetter(request);

            // Assert
            Assert.Equal((int)MechanizedLetterResult.MechanizedLetter_mainRcvOrTranscriptRcv_Is_Not_Valid, result.Result.Result.Code);
        }


        //[Fact]
        //public void RecieveMechanizedLetter_SuccessfullyExecuted_ShouldReturnSuccessfulResult()
        //{

        //    //Arrange

        //_unitOfWork.Setup(setup => setup.Repositorey<GMechanizedLetterTypeRepository>().GetByCode(It.IsAny<string>()))
        // .ReturnsAsync((GMechanizedLetterType)null);


        //    var request = new MechanizedLetterRequest()
        //    {

        //        TheGMechanizedLetterContract = new GMechanizedLetterContract()
        //        {
        //            CreatorUserName = "creatorUserName",
        //            LetterText = "تست",
        //            OuterOrgLetterDate = "1398/04/01",
        //            OuterOrgLetterNo = "3445",
        //            TheGMechanizedLetterTypeContract = new GMechanizedLetterTypeContract
        //            {
        //                Code = "00027"
        //            },
        //            TheNAJAUnitContract = new NAJAUnitContract
        //            {
        //                Code = "00025"
        //            },

        //            TheGMechanizedLetterCaseContractList = new List<GMechanizedLetterCaseContract>()
        //            {
        //                new GMechanizedLetterCaseContract
        //                {
        //                  RelatedCaseNo = "139400118012001925",
        //                  RelatedCaseTitle = "relatedCaseTitle",
        //                    TheunitContract = new unitContract
        //                    {
        //                        Code= "18066"

        //                    }

        //                }



        //            },
        //            TheGMechanizedLetterReceiverContractList = new List<GMechanizedLetterReceiverContract>()
        //            {
        //                new GMechanizedLetterReceiverContract
        //                {
        //                    MainRcvOrTranscriptRcv= Anu.BaseInfo.Enumerations.MechanizedLetterMainRcvOrTranscriptRcv.MainReceiver,
        //                    ReceiverType= Anu.BaseInfo.Enumerations.MechanizeRefererType.Unit,
        //                    TheCMSOrganizationContract= new CMSOrganizationContract{
        //                      Code= "01141"
        //                      },
        //                      TheCMSUserRoleTypeContract= new CMSUserRoleTypeContract{
        //                      Code= "0006"
        //                      }
        //                }


        //            },
        //            //TheGMechanizedLetterFieldsContractList = new List<GMechanizedLetterFieldsContract>()
        //            //{

        //            //},
        //            TheGMechanizedLetterRelLettersContractList = new List<GMechanizedLetterRelLettersContract>()
        //            {
        //                new GMechanizedLetterRelLettersContract{
        //                    RelationType=Anu.BaseInfo.Enumerations.MechanizedLetterRelType.Follower,
        //                    RelLetterDate="1395/03/20",
        //                    RelLetterGetType= Anu.BaseInfo.Enumerations.MechanizedLetterRelLetterGetType.Mechanize,
        //                    RelLetterNo= "14019860300000021"

        //                }
        //            }


        //        }

        //    };

        //    //Act
        //    var result = controller.SendMechanizedLetter(request);

        //    //Assert
        //    Assert.Equal((int)AnuResult.Successful, result.Result.Result.Code);
        //    //  Assert.Equal(MechanizedLetterResult.MechanizedLetter_CreatorUserName_Is_Null.GetResult(), result.Result);
        //}

    }
}
