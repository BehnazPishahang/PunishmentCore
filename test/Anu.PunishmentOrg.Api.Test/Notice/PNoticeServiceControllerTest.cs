using Anu.BaseInfo.Domain.Types;
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.PunishmentOrg.Api.Notice;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Domain.Notice;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anu.BaseInfo.Enumerations;
using Utility;
using Utility.Exceptions;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Notice
{
    public class PNoticeServiceControllerTest
    {
        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork;
        private readonly PNoticeServiceController _pNoticeServiceController;
        private readonly ChangePNoticeViewByUserStatusRequest? _changePNoticeViewByUserStatusRequest;
        private readonly GetCountOfUnSeenPNoticeByUserRequest? _getCountOfUnSeenPNoticeByUserRequest;
        private readonly List<PNotice> _pNoticesList;

        public PNoticeServiceControllerTest()
        {
            _unitOfWork = new Mock<Anu.DataAccess.IUnitOfWork>();
            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetPNoticeByNo(It.IsAny<string>()))!.ReturnsAsync(new PNotice());
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
                new() 
                { 
                    No             = "123",
                    IsViewedOnSite = YesNo.No
                },
                new()
                {
                    No             = "456",
                    IsViewedOnSite = YesNo.No
                },
                new()
                {
                    No             = "789",
                    IsViewedOnSite = YesNo.No
                },
                new()
                {
                    No             = "101",
                    IsViewedOnSite = YesNo.Yes
                },
            };
        }

        #region GetCountOfUnSeenPNoticeByUser

        [Fact]
        public Task GetCountOfUnSeenPNoticeByUser_Should_Return_Error30251_When_Request_Is_Null()
        {
            //Arrange

            GetCountOfUnSeenPNoticeByUserRequest? localGetCountOfUnSeenPNoticeByUserRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_Request_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task GetCountOfUnSeenPNoticeByUser_Should_Return_Error30252_When_NationalityCode_Is_Null()
        {
            //Arrange

            var localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
            {
                ThePNoticePersonContract = null
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_ThePNoticePersonContract_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Theory]
        [InlineData("test")]
        [InlineData(" ")]
        [InlineData(null)]
        public Task GetCountOfUnSeenPNoticeByUser_Should_Return_Error30253_When_No_IsNot_Valid(string nationalCode)
        {
            //Arrange

            var localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
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
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task GetCountOfUnSeenPNoticeByUser_Should_Return_Error30254_When_PNotice_NotFound()
        {
            //Arrange

            var localGetCountOfUnSeenPNoticeByUserRequest = new GetCountOfUnSeenPNoticeByUserRequest()
            {
                ThePNoticePersonContract = new PNoticePersonContract()
                {
                    NationalityCode = "1111111111",
                }
            };

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>())).ReturnsAsync((List<PNotice>)null!);

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(localGetCountOfUnSeenPNoticeByUserRequest)).Result;

            //Assert

            Assert.Equal((int)GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_PNotice_NotFound, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public async Task GetCountOfUnSeenPNoticeByUser_Should_Update()
        {
            //Arrange


            //Act

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>()))
                       .ReturnsAsync(_pNoticesList);

            var result = await _pNoticeServiceController.GetCountOfUnSeenPNoticeByUser(_getCountOfUnSeenPNoticeByUserRequest);

            //Assert
            var totalNoticeCount = 0;
            var unSeenNoticeCount = 0;
            var seenNoticeCount = 0;

            totalNoticeCount  = _pNoticesList.Count;
            // ReSharper disable once RedundantEnumerableCastCall
            unSeenNoticeCount = _pNoticesList.OfType<PNotice>().Count(x => x.IsViewedOnSite is not YesNo.Yes);
            seenNoticeCount   = totalNoticeCount - unSeenNoticeCount;

            Assert.Equal(_getCountOfUnSeenPNoticeByUserRequest?.ThePNoticePersonContract!.NationalityCode, result.TheGetCountOfUnSeenPNoticeByUserContract.NoticePersonNationalityCode);
            Assert.Equal(totalNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.TotalCountPNoticeOfUser);
            Assert.Equal(unSeenNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.CountUnSeenPNoticeByUser);
            Assert.Equal(seenNoticeCount, result.TheGetCountOfUnSeenPNoticeByUserContract.CountSeenedOfPNoticeByUser);
        }

        #endregion GetCountOfUnSeenPNoticeByUser

        #region ChangePNoticeViewByUserStatus

        [Fact]
        public Task ChangePNoticeViewByUserStatus_Should_Return_Error30241_When_Request_Is_Null()
        {
            //Arrange

            ChangePNoticeViewByUserStatusRequest? localChangePNoticeViewByUserStatusRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_Request_Is_Required, exception.result.Code);
            return Task.CompletedTask;
        }

        [Fact]
        public Task ChangePNoticeViewByUserStatus_Should_Return_Error30242_When_PNoticeNoInputContract_Is_Null()
        {
            //Arrange

            var localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
            {
                ThePNoticeNoInputContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

            //Assert

            Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_ThePNoticeNoInputContract_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Theory]
        [InlineData("test")]
        [InlineData(" ")]
        [InlineData(null)]
        public Task ChangePNoticeViewByUserStatus_NoIsNotValid_Should_Return_Error30243(string invalidNo)
        {
            //Arrange

            var localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
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
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task ChangePNoticeViewByUserStatus_Should_Return_Error30244_When_PNotice_NotFound()
        {
            //Arrange

            var localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
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
            return Task.CompletedTask;
        }

        [Fact]
        public async Task ChangePNoticeViewByUserStatus_Should_Update_PNotice()
        {
            //Arrange

            var thePNotice = new PNotice()
            {
                IsViewedOnSite      = YesNo.No,
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
                                        Code = Constants.ServiceModel.BaseInfo.BaseInfoConstants.NoticeResultTypeCode.NotificationThroughTheSite,
                                     });

            var result = await _pNoticeServiceController.ChangePNoticeViewByUserStatus(_changePNoticeViewByUserStatusRequest);

            //Assert

            Assert.Equal(YesNo.Yes, thePNotice.IsViewedOnSite);
            //Assert.Equal(DateTime.Now.ToPersianDateTime().Substring(0, 10), thePNotice.NoticeDate);
            Assert.Equal(Constants.ServiceModel.BaseInfo.BaseInfoConstants.NoticeResultTypeCode.NotificationThroughTheSite, thePNotice.TheNoticeResultType.Code);
        }

        #endregion ChangePNoticeViewByUserStatus

        #region InqueryPNoticeList

        [Fact]
        public Task InqueryPNoticeList_Should_Return_Error30201_When_Request_Is_Null()
        {
            //Arrange

            PNoticeInqueryRequest? localPNoticeInqueryRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.InqueryPNoticeList(localPNoticeInqueryRequest)).Result;

            //Assert

            Assert.Equal((int)InqueryPNoticeListResult.PNotice_InqueryPNoticeList_Request_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task InqueryPNoticeList_Should_Return_Error30202_When_NationalityCode_Is_Null()
        {
            //Arrange

            var localInqueryPNoticeListRequest = new PNoticeInqueryRequest()
            {
                PNoticePersonContract = null
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.InqueryPNoticeList(localInqueryPNoticeListRequest)).Result;

            //Assert

            Assert.Equal((int)InqueryPNoticeListResult.PNotice_InqueryPNoticeList_ThePNoticePersonContract_Is_Required, exception.result.Code);
            return Task.CompletedTask;
        }

        [Theory]
        [InlineData(" ")]
        [InlineData(null)]
        public Task InqueryPNoticeList_Should_Return_Error30203_When_No_IsNot_Valid(string nationalCode)
        {
            //Arrange

            var localInqueryPNoticeListRequest = new PNoticeInqueryRequest()
            {
                PNoticePersonContract = new PNoticePersonContract()
                {
                    NationalityCode = nationalCode,
                }
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.InqueryPNoticeList(localInqueryPNoticeListRequest)).Result;

            //Assert

            Assert.Equal((int)InqueryPNoticeListResult.PNotice_InqueryPNoticeList_NationalityCode_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task InqueryPNoticeList_Should_Return_Error50002_When_PNotice_Is_Null()
        {
            //Arrange

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(), new Page())).ReturnsAsync((List<PNotice>)null);

            var controller = new PNoticeServiceController(_unitOfWork.Object);

            //Act

            var result = controller.InqueryPNoticeList(new PNoticeInqueryRequest()
            {
                PNoticePersonContract = new PNoticePersonContract()
                {
                    NationalityCode = "23232322"
                }
            });

            //Assert

            Assert.Equal((int)InqueryPNoticeListResult.PNotice_InqueryPNoticeList_NotFound, result.Result.Result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task InqueryPNoticeList_EnterNationalCode_ReturenedListOfNotices()
        {
            //Arrange
            var expectedResponse = new PNoticeInqueryResponse()
            {
                PNotice = new Page<List<PNoticeContract>> 
                { 
                    Data = new List<PNoticeContract>() 
                    {
                        CreateRandomPNoticeContract("1"),
                        CreateRandomPNoticeContract("2")
                    } 
                },
                Result  = AnuResult.Successful.GetResult()
            };

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(), It.IsAny<Page>()))
                       .ReturnsAsync(new[] 
                       { 
                           CreateRandomPNotice("1"), 
                           CreateRandomPNotice("2") 
                       });


            var controller = new PNoticeServiceController(_unitOfWork.Object);

            //Act
            var result = controller.InqueryPNoticeList(
               new PNoticeInqueryRequest()
               {
                   PNoticePersonContract = new PNoticePersonContract() 
                   { 
                       NationalityCode = "23232322" 
                   },
                   Page = new Page() 
                   { 
                       PageNumber      = 0, 
                       RowCountPerPage = 0, 
                       TotallPage      = 0, 
                       TotalResult     = 0, 
                       OrderPage       = new OrderPage() 
                       { 
                           Property  = "", 
                           Ascending = false 
                       } 
                   }
               });

            //Assert
            result.Should().BeEquivalentTo(expectedResponse,
                options => options.ComparingByMembers<List<PNoticeContract>>().ExcludingMissingMembers());
            return Task.CompletedTask;
        }

        #endregion InqueryPNoticeList

        #region ExportPNotice

        [Fact]
        public Task ExportPNotice_RequestIsNull_ShouldReturn_Error30211()
        {
            //Arrange

            ExportPNoticeRequest localExportPNoticeRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest)).Result;

            //Assert

            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_Request_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task ExportPNotice_Should_Return_Error30212_When_PNoticeNoInputContract_Is_Null()
        {
            //Arrange

            var localExportPNoticeRequest = new ExportPNoticeRequest()
            {
                ThePNoticeNoInputContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest)).Result;

            //Assert

            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_ThePNoticeNoInputContract_Is_Required, exception.result.Code);
            return Task.CompletedTask;
        }

        [Theory]
        [InlineData(" ")]
        [InlineData(null)]
        public Task ExportPNotice_Should_Return_Error30213_When_No_IsNot_Valid(string invalidNo)
        {
            //Arrange

            var localExportPNoticeRequest = new ExportPNoticeRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = invalidNo,
                }
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest)).Result;

            //Assert

            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_No_Is_Required, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public Task ExportPNotice_Should_Return_Error30214_When_PNotice_NotFound()
        {
            //Arrange

            var localExportPNoticeRequest = new ExportPNoticeRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = "111",
                }
            };
            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest)).Result;

            //Assert

            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_NotFound, exception.result.Code);
            return Task.CompletedTask;
        }

        [Fact]
        public Task ExportPNotice_Should_Return_Error30215_When_Description_Is_Null()
        {
            //Arrange

            var localExportPNoticeRequest = new ExportPNoticeRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = "111",
                }
            };

            var thePNotice = new PNotice()
            {
                Description = null,
            };

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>()
                                          .GetPNoticeByNo(It.IsAny<string>()))
                       .ReturnsAsync(thePNotice);

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest)).Result;

            //Assert

            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_Description_NotFound, exception.result.Code);
            
            return Task.CompletedTask;
        }

        [Fact]
        public async Task ExportPNotice_Should_Retrun_file()
        {
            //Arrange
            var localExportPNoticeRequest = new ExportPNoticeRequest()
            {
                ThePNoticeNoInputContract = new PNoticeNoInputContract()
                {
                    No = "111",
                }
            };

            var thePNotice = new PNotice()
            {
                Description          = "test",
                ThePNoticePersonList = new List<PNoticePerson>(),
            };

            //Act

            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>()
                                          .GetPNoticeByNo(It.IsAny<string>()))
                       .ReturnsAsync(thePNotice);


            var result = await _pNoticeServiceController.ExportPNotice(localExportPNoticeRequest);

            //Assert

            Assert.NotNull(result.ThePNoticeExportContract);
            Assert.NotNull(result.ThePNoticeExportContract!.Pdf);
            Assert.True(Convert.TryFromBase64String(result.ThePNoticeExportContract.Pdf!, new Span<byte>(new byte[result.ThePNoticeExportContract.Pdf!.Length]), out var bytesParsed));
        }

        #endregion ExportPNotice

        private static PNotice CreateRandomPNotice(string noPostFix)
        {
            return new PNotice()
            {
                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
                No = $"140000000000000000{noPostFix}",
                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
                NoticePersonFamily = "km",
                NoticePersonName = "soheil",
                ThePNoticePersonList = new List<PNoticePerson>(),
            };
        }

        private static PNoticeContract CreateRandomPNoticeContract(string noPostFix)
        {
            return new PNoticeContract()
            {
                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
                No = $"140000000000000000{noPostFix}",
                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
                NoticePersonFamily = "km",
                NoticePersonName = "soheil",
                ThePCaseContract = new ServiceModel.Case.PCaseContract() 
                { 
                    No = "11111111111111",
                }
            };
        }
    }
}