﻿using Anu.PunishmentOrg.Api.Gravamen;
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
        var p2 = new PGravamenPerson()
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

        var v = new PGravamenViolation()
        {

            RowNumber = 1,
            SubjectTitle = "Geran Forooshi",
            ViolationAddress = "Azadi St.",
            ViolationDate = "1401/06/02",
            ViolationDesc = "Geran Forooshi Ba Tozihat",
            ViolationPrice = 10000,
        };

        var a = new PGravamenAttachment()
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

        pGravamen = new PGravamen()
        {

            PetitionSubject = "Petition Subject",
            PetitionDescription = "Petition Description",
            NoticeText = "Notice Text",
            PetitionReasons = "PetitionReasons",
            RejectReasonText = "Reject Reason Text",
            ReporterName = "Ali",
            ReporterFamily = "Pooyan",
            ReporterMobilNumber = "09101112233",

            ThePGravamenPersonList = new List<PGravamenPerson>() { p1, p2 },
            ThePGravamenAttachmentList = new List<PGravamenAttachment>() { a },
            ThePGravamenViolationList = new List<PGravamenViolation>() { v },

            CreateDateTime = "1401/02/06",
            FollowUpNo = "9995541",
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
