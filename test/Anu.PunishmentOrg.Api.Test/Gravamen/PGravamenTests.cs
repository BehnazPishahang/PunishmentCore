using Anu.PunishmentOrg.Api.Gravamen;
using Anu.PunishmentOrg.DataAccess.PGravamen;
using Anu.PunishmentOrg.DataModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Moq;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Enumerations;
using System;

namespace Anu.PunishmentOrg.Api.Test.Gravamen;

public class PGravamenTests
{
    private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();
    private readonly PGravamenServiceController controller;


    /// xUnit uses the constructor for set up method
    public PGravamenTests()
    {
        //    _unitOfWork.Setup(repo => repo.Repositorey<PGravamenRepository>().GetAll())
        //        .ReturnsAsync((IEnumerable<PGravamen>)null);

        controller = new PGravamenServiceController(_unitOfWork.Object);
    }

    [Fact]
    public void RecieveGravamen_SuccessfullyExecuted_ShouldReturnSuccessfulResult()
    {
        //Arrange
        var request = new PGravamenServiceRequest()
        {
            ThePGravamenContract = new PGravamenContract()
            {
                NoticeText = "متن شکوائیه از این قرار است",
                PetitionDescription = "ت.ضاحات شکوائیه",
                PetitionReasons = "",
                PetitionSubject = "",
                RejectReasonText = "",
                ReporterName = "",
                ReporterFamily = "",
                ReporterMobilNumber = "",
                ThePGravamenPersonContractList = new List<PGravamenPersonContract>()
                {
                    new PGravamenPersonContract()
                    {
                        Name ="Person1",
                        PersonStartPost=PUPersonStartPost.PlaintiffPerson
                    },
                    new PGravamenPersonContract()
                    {
                        Name ="Person2",
                        PersonStartPost=PUPersonStartPost.OffendingPerson
                    },
                }
            }

        };

        //Act
        var result = controller.RecieveGravamen(request);

        //Assert
        Assert.Equal((int)AnuResult.Successful, result.Result.Result.Code);
    }


    [Fact]
    public void RecieveGravamen_RequestIsNull_ShouldReturnRequestIsNullOrCorrupt()
    {
        //Arrange
        PGravamenServiceRequest request = null;

        //Act
        var result = controller.RecieveGravamen(request);

        //Assert
        Assert.Equal((int)PGravamenResult.PGravamen_Request_IsNullOrCorrupt, result.Result.Result.Code);
    }

    [Fact]
    public void RecieveGravamen_OneOfNecessaryFieldsIsMissing_ShouldReturnPGravamenFieldIsNullOrInvalid()
    {
        //Arrange
        var request = new PGravamenServiceRequest()
        {
            ThePGravamenContract = new PGravamenContract()
            {
                NoticeText = "متن شکوائیه از این قرار است",
                PetitionDescription = "ت.ضاحات شکوائیه",
                //PetitionReasons = "",
                PetitionSubject = "",
                RejectReasonText = "",
                ReporterName = "",
                ReporterFamily = "",
                ReporterMobilNumber = "",
                ThePGravamenPersonContractList = new List<PGravamenPersonContract>()
                {
                    new PGravamenPersonContract()
                    {
                        Name ="Person1",
                        PersonStartPost=PUPersonStartPost.PlaintiffPerson
                    },
                    new PGravamenPersonContract()
                    {
                        Name ="Person2",
                        PersonStartPost=PUPersonStartPost.OffendingPerson
                    },
                }
            }

        };

        //Act
        var result = controller.RecieveGravamen(request);

        //Assert
        Assert.Equal((int)PGravamenResult.PGravamen_Field_IsNullOrInvalid, result.Result.Result.Code);
    }
     [Fact]
    public void RecieveGravamen_OneOfNecessaryPositionsIsMissing_ShouldReturnPGravamenNecessaryPositionsAreNotAvailabe()
    {
        //Arrange
        var request = new PGravamenServiceRequest()
        {
            ThePGravamenContract = new PGravamenContract()
            {
                NoticeText = "متن شکوائیه از این قرار است",
                PetitionDescription = "ت.ضاحات شکوائیه",
                PetitionReasons = "test",
                PetitionSubject = "test",
                RejectReasonText = "test",
                ReporterName = "test",
                ReporterFamily = "test",
                ReporterMobilNumber = "test",
                ThePGravamenPersonContractList = new List<PGravamenPersonContract>()
                {
                    new PGravamenPersonContract()
                    {
                        Name ="Person1",
                        PersonStartPost=null
                    },
                    new PGravamenPersonContract()
                    {
                        Name ="Person2",
                        PersonStartPost=PUPersonStartPost.OffendingPerson
                    },
                }
            }

        };

        //Act
        var result = controller.RecieveGravamen(request);

        //Assert
        Assert.Equal((int)PGravamenResult.PGravamen_NecessaryPositions_AreNotAvailabe, result.Result.Result.Code);
    }



    ///xUnit uses the Dispose for tear down method
    //public void Dispose()
    //{

    //}
}
