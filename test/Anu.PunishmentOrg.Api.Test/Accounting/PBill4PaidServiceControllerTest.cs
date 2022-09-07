using Anu.PunishmentOrg.Api.Accounting;
using Anu.PunishmentOrg.Api.Notice;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.Accounting;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Accounting
{
    public class PBill4PaidServiceControllerTest
    {

        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork;
        private readonly PBill4PaidServiceController _pBill4PaidServiceController;

        public PBill4PaidServiceControllerTest()
        {
            _unitOfWork = new Mock<Anu.DataAccess.IUnitOfWork>();
            _pBill4PaidServiceController = new PBill4PaidServiceController(_unitOfWork.Object);
        }

        #region GetPaymentInfo

        [Fact]
        public async Task GetPaymentInfo_RequestIsNull_ShouldReturn_Error30261()
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_Request_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_PBill4PaidFishNoContractIsNull_ShouldReturn_Error30262()
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            { 
                ThePBill4PaidFishNoContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_ThePBill4PaidFishNoContract_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_FishNoIsNull_ShouldReturn_Error30263()
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract() 
                { 
                    FishNo = null,
                },
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required, exception.result.Code);
        }

        //[Theory]
        //[InlineData("test")]
        //[InlineData(" ")]
        //[InlineData(null)]
        //public async Task ChangePNoticeViewByUserStatus_NoIsNotValid_Should_Return_Error30243(string invalidNo)
        //{
        //    //Arrange

        //    ChangePNoticeViewByUserStatusRequest localChangePNoticeViewByUserStatusRequest = new ChangePNoticeViewByUserStatusRequest()
        //    {
        //        ThePNoticeNoInputContract = new PNoticeNoInputContract()
        //        {
        //            No = invalidNo,
        //        }
        //    };

        //    //Act

        //    var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pNoticeServiceController.ChangePNoticeViewByUserStatus(localChangePNoticeViewByUserStatusRequest)).Result;

        //    //Assert

        //    Assert.Equal((int)ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNoticeNo_Is_Required, exception.result.Code);
        //}

        //[Fact]
        //public async Task GetPaymentInfo_PBill4Paid_NotFound_ShouldReturn_Error30264()
        //{
        //    //Arrange



        //    //Act

        //    var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

        //    //Assert

        //    Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required, exception.result.Code);
        //}

        #endregion GetPaymentInfo


    }
}
