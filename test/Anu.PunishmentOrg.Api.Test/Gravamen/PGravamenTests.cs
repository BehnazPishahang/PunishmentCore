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
using System.Text;

namespace Anu.PunishmentOrg.Api.Test.Gravamen;

public class PGravamenTests
{
    private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();
    private readonly PGravamenServiceController controller;
    private readonly PGravamen pGravamen;


    /// xUnit uses the constructor for set up method
    public PGravamenTests()
    {
        //    _unitOfWork.Setup(repo => repo.Repositorey<PGravamenRepository>().GetAll())
        //        .ReturnsAsync((IEnumerable<PGravamen>)null);

        controller = new PGravamenServiceController(_unitOfWork.Object);

        #region PGravamen Instatiation
        var p1 = new PGravamenPerson()
        {

            Name = "",
            Family = "",
            Address = "",
            BirthDate = "",
            FatherName = "",
            IdentityNumber = "",
            MobilNumber = "",
            NationalCode = "",
            Nationality = BaseInfo.Enumerations.LNationality.Iranian,
            PersonStartPost = Enumerations.PUPersonStartPost.PlaintiffPerson,
            Sex = BaseInfo.Enumerations.SexType.Male,
            PersonType = BaseInfo.Enumerations.PersonType.NaturalPerson,
            PostCode = "",
            TradeUnitName = "",
            PersonPassword = "",
        };
        var p2 = new PGravamenPerson()
        {

            Name = "",
            Family = "",
            Address = "",
            BirthDate = "",
            FatherName = "",
            IdentityNumber = "",
            MobilNumber = "",
            NationalCode = "",
            Nationality = BaseInfo.Enumerations.LNationality.Iranian,
            PersonStartPost = Enumerations.PUPersonStartPost.OffendingPerson,
            Sex = BaseInfo.Enumerations.SexType.Male,
            PersonType = BaseInfo.Enumerations.PersonType.NaturalPerson,
            PostCode = "",
            TradeUnitName = "KH",
            PersonPassword = "",
        };

        var v = new PGravamenViolation()
        {

            RowNumber = 1,
            SubjectTitle = "a",
            ViolationAddress = "b",
            ViolationDate = "c",
            ViolationDesc = "d",
            ViolationPrice = 123,
        };

        var a = new PGravamenAttachment()
        {
            FileExtension = BaseInfo.Enumerations.FileExtension.PDF,
            TheAttachmentType = new BaseInfo.DataModel.Types.AttachmentType()
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

        pGravamen = new PGravamen()
        {

            PetitionSubject = "d",
            PetitionDescription = "e",
            NoticeText = "f",
            PetitionReasons = "g",
            RejectReasonText = "h",
            ReporterName = "i",
            ReporterFamily = "j",
            ReporterMobilNumber = "k",

            ThePGravamenPersonList = new List<PGravamenPerson>() { p1, p2 },
            ThePGravamenAttachmentList = new List<PGravamenAttachment>() { a },
            ThePGravamenViolationList = new List<PGravamenViolation>() { v },

            CreateDateTime = "l",
            FollowUpNo = "m",
            HowDataType = Enumerations.PU135OrWebSite.WebSite,
            GravamenOrReport = Anu.PunishmentOrg.Enumerations.GravamenOrReport.Gravamen,
        };
        #endregion
    }

    [Fact(Skip = "This scenario will be passed after all of the other scenarios have passed.", DisplayName = "Success Scenario")]
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

    [Fact]
    public void RecieveGravamen_OneOfPlaintiffPersonNecessaryFiledsIsMissing_ReturnsPGravamenPlatiffNecessaryFieldIsNullOrInvalid()
    {
       
    }


    ///xUnit uses the Dispose for tear down method
    //public void Dispose()
    //{

    //}
}
