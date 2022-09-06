using Anu.BaseInfo.Domain.Types;
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.Api.Notice;
using Anu.PunishmentOrg.DataAccess.Notice;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Domain.Notice;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Notice
{
    public class PNoticeServiceControllerTest
    {
        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork;
        private readonly PNoticeServiceController _pNoticeServiceController;
        private readonly ChangePNoticeViewByUserStatusRequest _changePNoticeViewByUserStatusRequest;
        private readonly PNoticeInqueryRequest _pNoticeInqueryRequest;
        private readonly ExportPNoticeRequest _exportPNoticeRequest;
        private readonly GetCountOfUnSeenPNoticeByUserRequest _getCountOfUnSeenPNoticeByUserRequest;
        private List<PNotice> _pNoticesList;
        private PNotice _pNotice;

        public PNoticeServiceControllerTest()
        {
            _unitOfWork = new Mock<Anu.DataAccess.IUnitOfWork>();
            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetPNoticeByNo(It.IsAny<string>())).ReturnsAsync(_pNotice);
            _pNoticeServiceController = new PNoticeServiceController(_unitOfWork.Object);
            _changePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                { 
                    No = "140001212022001521",
                }
            };

            _getCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
            {
                ThePNoticePersonContract = new PNoticePersonContract()
                {
                    NationalityCode = "1729049885",
                }
            };

            _pNoticesList = new List<PNotice>() 
            { 
                new PNotice() 
                { 
                    No             = "123",
                    IsViewedOnSite = Anu.BaseInfo.Enumerations.YesNo.No
                },
                new PNotice()
                {
                    No             = "456",
                    IsViewedOnSite = Anu.BaseInfo.Enumerations.YesNo.No
                },
                new PNotice()
                {
                    No             = "789",
                    IsViewedOnSite = Anu.BaseInfo.Enumerations.YesNo.No
                },
                new PNotice()
                {
                    No             = "101",
                    IsViewedOnSite = Anu.BaseInfo.Enumerations.YesNo.Yes
                },
            };
        }

        #region ChangePNoticeViewByUserStatus

        [Fact]
        public async Task ChangePNoticeViewByUserStatus_RequestIsNull_ShouldReturn_Error30241()
        {
            //Arrange

            ChangePNoticeViewByUserStatusRequest localChangePNoticeViewByUserStatusRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_Request_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task ChangePNoticeViewByUserStatus_PNoticeNoInputContractIsNull_Should_Return_Error30242()
        {
            //Arrange

            ChangePNoticeViewByUserStatusRequest localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
            {
                ThePNoticeNoInputContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_ThePNoticeNoInputContract_Is_Required, exception.result.Code);
        }

        [Theory]
        [InlineData("test")]
        [InlineData(" ")]
        [InlineData(null)]
        public async Task ChangePNoticeViewByUserStatus_NoIsNotValid_Should_Return_Error30243(string invalidNo)
        {
            //Arrange

            ChangePNoticeViewByUserStatusRequest localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = invalidNo,
                }
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNoticeNo_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task ChangePNoticeViewByUserStatus_PNoticeNotFound_Should_Return_Error30244()
        {
            //Arrange

            ChangePNoticeViewByUserStatusRequest localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = "111",
                }
            };
            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNotice_NotFound, exception.result.Code);
        }

        [Fact]
        public async Task ChangePNoticeViewByUserStatus_Should_Update_PNotice()
        {
            //Arrange

            PNotice thePNotice = new PNotice()
            {
                IsViewedOnSite      = Anu.BaseInfo.Enumerations.YesNo.No,
                NoticeDate          = null,
                TheNoticeResultType = null,
            };

            //Act

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>()
                                          .GetPNoticeByNo(It.IsAny<string>()))
                       .ReturnsAsync(thePNotice);

            _unitOfWork.Setup(repo => repo.Repositorey<INoticeResultTypeRepository>()
                                          .GetNoticeResultTypeWithCode(It.IsAny<string>()))
                       .ReturnsAsync(new Anu.BaseInfo.DataModel.Types.NoticeResultType() 
                                     { 
                                        Code = Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.NoticeResultTypeCode.NotificationThroughTheSite,
                                     });

            var result = await _pNoticeServiceController.ChangePNoticeViewByUserStatus(_changePNoticeViewByUserStatusRequest);

            //Assert

            Assert.Equal(Anu.BaseInfo.Enumerations.YesNo.Yes, thePNotice.IsViewedOnSite);
            Assert.Equal(DateTime.Now.ToPersian().ToString().Substring(0, 10), thePNotice.NoticeDate);
            Assert.Equal(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.NoticeResultTypeCode.NotificationThroughTheSite, thePNotice.TheNoticeResultType.Code);
        }

        #endregion ChangePNoticeViewByUserStatus


        #region GetCountOfUnSeenPNoticeByUser

        [Fact]
        public async Task GetCountOfUnSeenPNoticeByUser_RequestIsNull_ShouldReturn_Error30251()
        {
            //Arrange

            GetCountOfUnSeenPNoticeByUserRequest localGetCountOfUnSeenPNoticeByUserRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_Request_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetCountOfUnSeenPNoticeByUser_NationalityCodeIsNull_ShouldReturn_Error30252()
        {
            //Arrange

            GetCountOfUnSeenPNoticeByUserRequest localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
            {
                ThePNoticePersonContract = null
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_ThePNoticePersonContract_Is_Required, exception.result.Code);
        }

        [Theory]
        [InlineData("test")]
        [InlineData(" ")]
        [InlineData(null)]
        public async Task GetCountOfUnSeenPNoticeByUser_NoIsNotValid_Should_Return_Error30253(string nationalCode)
        {
            //Arrange

            GetCountOfUnSeenPNoticeByUserRequest localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
            {
                ThePNoticePersonContract = new PNoticePersonContract()
                {
                    NationalityCode = nationalCode,
                }
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_NationalityCode_Is_Required, exception.result.Code);
        }

        //[Fact]
        //public async Task GetCountOfUnSeenPNoticeByUser_PNoticeNotFound_Should_Return_Error30254()
        //{
        //    //Arrange

        //    GetCountOfUnSeenPNoticeByUserRequest localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
        //    {
        //        ThePNoticePersonContract = new PNoticePersonContract()
        //        {
        //            NationalityCode = "1111111111",
        //        }
        //    };

        //    //Act

        //    var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

        //    //Assert

        //    Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_PNotice_NotFound, exception.result.Code);
        //}

        [Fact]
        public async Task GetCountOfUnSeenPNoticeByUser_Should_Update()
        {
            //Arrange


            //Act

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>()))
                       .ReturnsAsync(_pNoticesList);

            var result = await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(_getCountOfUnSeenPNoticeByUserRequest);

            //Assert
            int totalNoticeCount  = 0;
            int unSeenNoticeCount = 0;
            int seenNoticeCount   = 0;

            totalNoticeCount  = _pNoticesList.Count();
            unSeenNoticeCount = _pNoticesList.OfType<PNotice>()
                                             .Where(x => x.IsViewedOnSite == Anu.BaseInfo.Enumerations.YesNo.No || 
                                                         x.IsViewedOnSite == Anu.BaseInfo.Enumerations.YesNo.None || 
                                                         x.IsViewedOnSite == null).Count();
            seenNoticeCount   = totalNoticeCount - unSeenNoticeCount;

            Assert.Equal(_getCountOfUnSeenPNoticeByUserRequest.ThePNoticePersonContract!.NationalityCode, result.TheGetCountOfUnSeenPNoticeByUserContract.NoticePersonNationalityCode);
            Assert.Equal(totalNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.TotalCountPNoticeOfUser);
            Assert.Equal(unSeenNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.CountUnSeenPNoticeByUser);
            Assert.Equal(seenNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.CountSeenedOfPNoticeByUser);
        }

        #endregion GetCountOfUnSeenPNoticeByUser

        //[Fact]
        //public async Task InqueryPNoticeList_PNoticeIsNull_ReturenedError50002()
        //{
        //    //Arrange
        //    _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(),
        //        new Page() { PageNumber = 0, RowCountPerPage = 0, TotallPage = 0, TotalResult = 0, OrderPage = new OrderPage() { Property = "", Ascending = false } }))
        //        .ReturnsAsync((IEnumerable<PNotice>)null);

        //    var controller = new PNoticeServiceController(_unitOfWork.Object);

        //    //Act

        //    var result = controller.InqueryPNoticeList(
        //        new ServiceModel.Notice.PNoticeInqueryRequest() { PNoticePersonContract = new PNoticePersonContract() { NationalityCode = "23232322" } });

        //    //Assert
        //    Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_NotFound, result.Result.Result.Code);
        //}

        //[Fact]
        //public async Task InqueryPNoticeList_EnterNationalCode_ReturenedListOfNotices()
        //{
        //    //Arrange
        //    var expectedResponse = new PNoticeInqueryResponse()
        //    {
        //        PNotice = new Page<List<PNoticeContract>> { Data = new List<PNoticeContract>() { CreateRandomPNoticeContract("1"), CreateRandomPNoticeContract("2") } },
        //        Result = AnuResult.Successful.GetResult()
        //    };

        //    _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(), It.IsAny<Page>()))
        //        .ReturnsAsync(new[] { CreateRandomPNotice("1"), CreateRandomPNotice("2") });


        //    var controller = new PNoticeServiceController(_unitOfWork.Object);

        //    //Act
        //    var result = controller.InqueryPNoticeList(
        //       new ServiceModel.Notice.PNoticeInqueryRequest()
        //       {
        //           PNoticePersonContract = new PNoticePersonContract() { NationalityCode = "23232322" },
        //           Page =
        //        new Page() { PageNumber = 0, RowCountPerPage = 0, TotallPage = 0, TotalResult = 0, OrderPage = new OrderPage() { Property = "", Ascending = false } }
        //       });

        //    //Assert
        //    result.Should().BeEquivalentTo(expectedResponse,
        //        options => options.ComparingByMembers<List<PNoticeContract>>().ExcludingMissingMembers());
        //}

        private PNotice CreateRandomPNotice(string noPostFix)
        {
            return new PNotice()
            {
                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
                No = $"140000000000000000{noPostFix}",
                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
                NoticePersonFamily = "km",
                NoticePersonName = "soheil"
            };
        }

        private PNoticeContract CreateRandomPNoticeContract(string noPostFix)
        {
            return new PNoticeContract()
            {
                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
                No = $"140000000000000000{noPostFix}",
                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
                NoticePersonFamily = "km",
                NoticePersonName = "soheil"
            };
        }

    }
}
