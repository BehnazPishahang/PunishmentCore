using Anu.BaseInfo.DataModel.GeoInfo;
using Anu.BaseInfo.DataModel.Security.Role;
using Anu.BaseInfo.DataModel.SystemConfiguration;
using Anu.BaseInfo.DataModel.SystemObject;
using Anu.BaseInfo.DataModel.Types;
using Anu.BaseInfo.Domain.GeoInfo;
using Anu.BaseInfo.Domain.OrganizationChart;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.BaseInfo.ServiceModel.Attachment;
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Accounting;
using Anu.PunishmentOrg.Api.Gravamen;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
using Anu.PunishmentOrg.Domain.PGravamen;
using Anu.PunishmentOrg.Enumerations;
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Moq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
            PersonStartPost = Enumerations.PUPersonStartPost.PlaintiffPerson,
            Sex = Anu.BaseInfo.Enumerations.SexType.Male,
            PostCode = "123456",
            TradeUnitName = "",
            PersonPassword = "",
        };
        var p2 = new PGravamenPersonContract()
        {

            Name = "",
            Family = "",
            Address = "Address",
            BirthDate = "",
            FatherName = "",
            IdentityNumber = "",
            MobilNumber = "",
            NationalCode = "",
            PersonStartPost = Enumerations.PUPersonStartPost.OffendingPerson,
            PostCode = "",
            TradeUnitName = "Nanvaii Haj Nemat",
            PersonPassword = "",
        };

        var a = new GAttachmentContract()
        {
            FileExtension = Anu.BaseInfo.Enumerations.FileExtension.PDF,
            TheAttachmentTypeContract = new Anu.BaseInfo.ServiceModel.Types.AttachmentTypeContract()
            {
                Code = Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.AttachmentTypeId.GravamenAttachmentTypeId,
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
            ThePGravamenPersonContractList = new List<PGravamenPersonContract>() { p1, p2 },
            TheGAttachmentContractList = new List<GAttachmentContract>() { a },
            TheGeoLocationContract = new GeoLocationContract()
            {
                LocationCode = "0507"
            },
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
            .ReturnsAsync(new AttachmentType());

        _unitOfWork.Setup(u => u.Repositorey<IObjectStateRepository>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new ObjectState());

        _unitOfWork.Setup(u => u.Repositorey<IGeoLocationRepository>().GetGeoLocationWithLocationCode(It.IsAny<string>()))
            .ReturnsAsync(new GeoLocation());

        _unitOfWork.Setup(u => u.Repositorey<IUnitRepository>().FindRelatedUnitToGeoLocation(It.IsAny<string>(), It.IsAny<List<string>>())).ReturnsAsync(new Anu.BaseInfo.DataModel.OrganizationChart.Unit()
        {
            TheCMSOrganizationList=new List<CMSOrganization>()
            {
                new CMSOrganization{Id="11"}
            }
        });

        _unitOfWork.Setup(u => u.Repositorey<IPGravamenRepository>().Add(It.IsAny<DataModel.Gravamen.PGravamen>()));

        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<BaseRole>>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new BaseRole());

        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<SystemObject>>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new SystemObject());

        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<SystemForm>>().GetById(It.IsAny<string>()))
            .ReturnsAsync(new SystemForm());

        _unitOfWork.Setup(u => u.Repositorey<IGenericRepository<WorkFlowInstanceWorkItem>>().Add(It.IsAny<WorkFlowInstanceWorkItem>()));

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
        _request.ThePGravamenContract!.PetitionDescription = null;

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
                Id = Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.AttachmentTypeId.GravamenAttachmentTypeId,
                Code = Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.AttachmentTypeId.GravamenAttachmentTypeId,
                Title = "Mock Attachemnt Type"
            });

        controller = new PGravamenServiceController(_unitOfWork.Object);

        var result = controller.RecieveGravamen(_request);

        Assert.Equal((int)PGravamenResult.PGravamen_FileIsLargerThanAllowedThreshold, result.Result.Result.Code);
    }


    #region GetPGravamenInfo

    [Fact]
    public async Task GetPGravamenInfo_RequestIsNull_ShouldReturn_Error30281()
    {
        //Arrange

        GetPGravamenInfoRequest localGetPGravamenInfoRequest = null;

        //Act

        var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await controller.GetPGravamenInfo(localGetPGravamenInfoRequest)).Result;

        //Assert

        Assert.Equal((int)GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_Request_Is_Required, exception.result.Code);
    }

    [Fact]
    public async Task GetPGravamenInfo_PGravamenFishNoContractIsNull_ShouldReturn_Error30282()
    {
        //Arrange

        GetPGravamenInfoRequest localGetPGravamenInfoRequest = new GetPGravamenInfoRequest()
        {
            ThePGravamenContract = null,
        };

        //Act

        var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await controller.GetPGravamenInfo(localGetPGravamenInfoRequest)).Result;

        //Assert

        Assert.Equal((int)GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_ThePGravamenContract_Is_Required, exception.result.Code);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(" ")]
    [InlineData("test")]
    public async Task GetPGravamenInfo_FishNo_IsNull_Or_Invalid_ShouldReturn_Error30283(string followUpNo)
    {
        //Arrange

        GetPGravamenInfoRequest localGetPGravamenInfoRequest = new GetPGravamenInfoRequest()
        {
            ThePGravamenContract = new PGravamenContract()
            {
                FollowUpNo = followUpNo,
            },
        };

        //Act

        var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await controller.GetPGravamenInfo(localGetPGravamenInfoRequest)).Result;

        //Assert

        Assert.Equal((int)GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_FollowUpNo_Is_Required, exception.result.Code);
    }

    [Fact]
    public async Task GetPGravamenInfo_PGravamen_NotFound_ShouldReturn_Error30284()
    {
        //Arrange
        GetPGravamenInfoRequest localGetPGravamenInfoRequest = new GetPGravamenInfoRequest()
        {
            ThePGravamenContract = new PGravamenContract()
            {
                FollowUpNo = "123",
            },
        };
        _unitOfWork.Setup(x => x.Repositorey<IPGravamenRepository>()
        .GetPGravamenByFollowUpNo(It.IsAny<string>()))
                   .ReturnsAsync((DataModel.Gravamen.PGravamen)null);

        //Act

        var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await controller.GetPGravamenInfo(localGetPGravamenInfoRequest)).Result;

        //Assert

        Assert.Equal((int)GetPGravamenInfoResult.PGravamen_GetPGravamenInfo_PGravamen_NotFound, exception.result.Code);
    }

    //[Theory]
    //[InlineData(.Confirmed, true)]
    //[InlineData(PBill4Cash.Paid, false)]
    //public async Task GetPGravamenInfo_When_State_Is_InputState_Then_OutputCanPay_Should_Be_Returned(string inputState, bool outputCanPay)
    //{
    //    //Arrange

    //    GetPGravamenInfoRequest localGetPGravamenInfoRequest = new GetPGravamenInfoRequest()
    //    {
    //        ThePGravamenFishNoContract = new PGravamenFishNoContract()
    //        {
    //            FishNo = "123"
    //        }
    //    };

    //    _unitOfWork.Setup(x => x.Repositorey<IPGravamenRepository>()
    //                            .GetPGravamenByFishNo(It.IsAny<string>()))
    //               .ReturnsAsync(new PGravamen()
    //               {
    //                   TheObjectState = new()
    //                   {
    //                       Code = inputState,
    //                   }
    //               });
    //    //Act

    //    var result = await controller.GetPGravamenInfo(localGetPGravamenInfoRequest);

    //    //Assert

    //    Assert.NotNull(result.ThePGravamenInfoContract);
    //    Assert.NotNull(result.ThePGravamenInfoContract!.Desc);
    //    Assert.IsType(typeof(bool), result.ThePGravamenInfoContract.CanPay);
    //    Assert.IsType(typeof(string), result.ThePGravamenInfoContract.Desc);
    //    Assert.Equal(outputCanPay, result.ThePGravamenInfoContract.CanPay);
    //}

    //[Fact]
    //public async Task GetPGravamenInfo_State_NotConfirmed_ShouldReturn__CanPay_False()
    //{
    //    //Arrange

    //    GetPGravamenInfoRequest localGetPGravamenInfoRequest = new GetPGravamenInfoRequest()
    //    {
    //        ThePGravamenFishNoContract = new PGravamenFishNoContract()
    //        {
    //            FishNo = "123"
    //        }
    //    };

    //    _unitOfWork.Setup(x => x.Repositorey<IPGravamenRepository>()
    //                            .GetPGravamenByFishNo(It.IsAny<string>()))
    //               .ReturnsAsync(new PGravamen()
    //               {
    //                   TheObjectState = new()
    //                   {
    //                       Code = It.IsAny<string>(),
    //                   }
    //               });
    //    //Act

    //    var result = await controller.GetPGravamenInfo(localGetPGravamenInfoRequest);

    //    //Assert

    //    Assert.NotNull(result.ThePGravamenInfoContract);
    //    Assert.NotNull(result.ThePGravamenInfoContract!.Desc);
    //    Assert.IsType(typeof(bool), result.ThePGravamenInfoContract.CanPay);
    //    Assert.IsType(typeof(string), result.ThePGravamenInfoContract.Desc);
    //    Assert.False(result.ThePGravamenInfoContract!.CanPay);
    //}
    #endregion GetPGravamenInfo

}
