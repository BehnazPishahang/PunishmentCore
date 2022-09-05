using Anu.BaseInfo.DataModel.Types;
using Anu.BaseInfo.Domain.GeoInfo;
using Anu.BaseInfo.Domain.OrganizationChart;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.BaseInfo.ServiceModel.Attachment;
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Gravamen;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Moq;
using System.Collections.Generic;
using System.Text;
using Utility.Exceptions;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Gravamen;

public class PGravamenTests
{
    private Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();
    private PGravamenServiceController controller;
    private PGravamenServiceRequest _request;


    /// xUnit uses the constructor for set up method
    public PGravamenTests()
    {

        controller = new PGravamenServiceController(_unitOfWork.Object);

        #region PGravamen Instantiation
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

        var a = new GAttachmentContract()
        {
            FileExtension = Anu.BaseInfo.Enumerations.FileExtension.PDF,
            TheAttachmentTypeContract = new Anu.BaseInfo.ServiceModel.Types.AttachmentTypeContract()
            {
                Code = "300",
                Title = "پيوست شكوائيه مردمي",
                State = Anu.BaseInfo.Enumerations.State.Valid,
                UnitTypeAccess = "1"
            },
            TheGAttachmentDataContract = new GAttachmentDataContract()
            {
                DocFile = Encoding.ASCII.GetBytes("QW51IGNvcG9yYXRpb24=")
            }
        };



        var pGravamen = new PGravamenContract()
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
            TheGAttachmentContractList = new List<GAttachmentContract>() { a },
            TheGeoLocationContract = new GeoLocationContract()
            {
                LocationCode = "0507"
            },

            CreateDateTime = "1401/02/06",
            FollowUpNo = "9995541",
            HowDataType = Enumerations.PU135OrWebSite.WebSite,
            GravamenOrReport = Anu.PunishmentOrg.Enumerations.GravamenOrReport.Gravamen,
        };



        #endregion

        _request = new PGravamenServiceRequest()
        {
            ThePGravamenContract = pGravamen
        };
    }

    [Fact(DisplayName = "Success Scenario")]
    public void RecieveGravamen_SuccessfullyExecuted_ShouldReturnSuccessfulResult()
    {
        //Arrange
        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<AttachmentType>>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new AttachmentType()
            {
                Id = "300",
                Code = "300",
                Title = "Mock Attachemnt Type"
            });
        _unitOfWork.Setup(u => u.Repositorey<IObjectStateRepository>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new Anu.BaseInfo.DataModel.SystemObject.ObjectState());

        _unitOfWork.Setup(u => u.Repositorey<IGeoLocationRepository>().GetGeoLocationWithLocationCode(It.IsAny<string>()))
            .ReturnsAsync(new Anu.BaseInfo.DataModel.GeoInfo.GeoLocation());

        //Todo: Setup this repo
        //_unitOfWork.Setup(u => u.Repositorey<IUnitRepository>().FindRelatedUnitToGeoLocation(It.IsAny<string>(), It.IsAny<List<string>>())
        //   .ReturnsAsync(new Anu.BaseInfo.DataModel.OrganizationChart.Unit());

        //Todo: Setup this repo
        //var pBCountyLocatedUnit = await _unitOfWork.Repositorey<IPBCountyLocatedUnitRepository>().GetRelatedPBCountyLocatedUnitToGeolocationWithLocationCode(theGeoLocation.LocationCode!);

        //And hopefully we are ready to pass this test

        //Act
        var result = controller.RecieveGravamen(_request);

        //Assert
        Assert.Equal((int)AnuResult.Successful, result.Result.Result.Code);
    }

    [Fact]
    public void RecieveGravamen_RequestIsNull_ShouldReturnRequestIsNullOrCorrupt()
    {
        //Arrange
        PGravamenServiceRequest request = null;

        //Act
        var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(request));

        //Assert
        //Assert.Equal((int)PGravamenResult.PGravamen_Request_IsNullOrCorrupt, result.Result.Result.Code);
        Assert.Equal((int)PGravamenResult.PGravamen_Request_IsNullOrCorrupt, result.Result.result.Code);
    }

    [Fact]
    public void RecieveGravamen_OneOfNecessaryFieldsIsMissing_ShouldReturnPGravamenFieldIsNullOrInvalid()
    {
        //Arrange
        _request.ThePGravamenContract!.PetitionReasons = null;

        //Act
        var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(_request));

        //Assert
        Assert.Equal((int)PGravamenResult.PGravamen_Field_IsNullOrInvalid, result.Result.result.Code);
    }
    [Fact]
    public void RecieveGravamen_OneOfNecessaryPositionsIsMissing_ShouldReturnPGravamenNecessaryPositionsAreNotAvailabe()
    {

        //Arrange
        _request.ThePGravamenContract!.ThePGravamenPersonContractList![0].PersonStartPost = null;

        //Act
        //var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(_request));
        var result = controller.RecieveGravamen(_request);

        //Assert
        Assert.Equal((int)PGravamenResult.PGravamen_NecessaryPositions_AreNotAvailabe, result.Result.Result.Code);
    }

    [Fact]
    public void RecieveGravamen_OneOfPlaintiffPersonNecessaryFiledsIsMissing_ReturnsPGravamenPlatiffNecessaryFieldIsNullOrInvalid()
    {
        _request.ThePGravamenContract!.ThePGravamenPersonContractList![0].Name = null;

        var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(_request));

        Assert.Equal((int)PGravamenResult.PGravamen_PlatiffNecessaryField_IsNullOrInvalid, result.Result.result.Code);
    }

    [Fact]
    public void RecieveGravamen_OneOfOffendingPersonNecessaryFiledsIsMissing_ReturnsPGravamenPlatiffNecessaryFieldIsNullOrInvalid()
    {
        _request.ThePGravamenContract!.ThePGravamenPersonContractList![1].TradeUnitName = null;

        var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(_request));

        Assert.Equal((int)PGravamenResult.PGravamen_OffendingNecessaryField_IsNullOrInvalid, result.Result.result.Code);
    }

    [Fact]
    public void RecieveGravamen_DocFileIsEmpty_ReturnsPGravamen_NoFileIsAttached()
    {
        _request.ThePGravamenContract!.TheGAttachmentContractList![0].TheGAttachmentDataContract!.DocFile = null;

        var result = Assert.ThrowsAnyAsync<AnuExceptions>(() => controller.RecieveGravamen(_request));

        Assert.Equal((int)PGravamenResult.PGravamen_NoFileIsAttached, result.Result.result.Code);
    }

    [Fact]
    public void RecieveGravamen_DocFileSize_IsMoreThan6MB_ReturnsPGravamen_FileIsLargerThanAllowedThreshold()
    {
        _request.ThePGravamenContract!.TheGAttachmentContractList![0].TheGAttachmentDataContract!.DocFile = new byte[60000000];

        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<AttachmentType>>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new AttachmentType()
            {
                Id = "300",
                Code = "300",
                Title = "Mock Attachemnt Type"
            });

        controller = new PGravamenServiceController(_unitOfWork.Object);

        var result = controller.RecieveGravamen(_request);

        Assert.Equal((int)PGravamenResult.PGravamen_FileIsLargerThanAllowedThreshold, result.Result.Result.Code);
    }



}
