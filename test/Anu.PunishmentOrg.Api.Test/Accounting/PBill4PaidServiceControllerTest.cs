using Anu.PunishmentOrg.Api.Accounting;
using Anu.PunishmentOrg.Api.Notice;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.Domain.Accounting;
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
using static Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgObjectState;

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

        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        [InlineData("test")]
        public async Task GetPaymentInfo_FishNo_IsNull_Or_Invalid_ShouldReturn_Error30263(string fishNo)
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = fishNo,
                },
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_FishNo_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_PBill4Paid_NotFound_ShouldReturn_Error30264()
        {
            //Arrange
            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = "123"
                }
            };


            _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
                                    .GetPBill4PaidByFishNo(It.IsAny<string>()))
                       .ReturnsAsync((PBill4Paid)null);
            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPaymentInfoResult.PBill4Paid_GetPaymentInfo_PBill4Paid_NotFound, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_State_Confirmed_ShouldReturn_CanPay_True()
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = "123"
                }
            };

            _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
                                    .GetPBill4PaidByFishNo(It.IsAny<string>()))
                       .ReturnsAsync(new PBill4Paid()
                       { 
                            TheObjectState = new()
                            { 
                                Code = PBill4Cash.Confirmed,
                            }
                       });
            //Act

            var result = await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest);

            //Assert

            Assert.NotNull(result.ThePBill4PaidInfoContract);
            Assert.NotNull(result.ThePBill4PaidInfoContract!.Desc);
            Assert.IsType(typeof(bool), result.ThePBill4PaidInfoContract!.CanPay);
            Assert.IsType(typeof(string), result.ThePBill4PaidInfoContract!.Desc);
            Assert.True(result.ThePBill4PaidInfoContract!.CanPay);
        }

        [Fact]
        public async Task GetPaymentInfo_State_NotConfirmed_ShouldReturn__CanPay_False()
        {
            //Arrange

            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = "123"
                }
            };

            _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
                                    .GetPBill4PaidByFishNo(It.IsAny<string>()))
                       .ReturnsAsync(new PBill4Paid()
                       {
                           TheObjectState = new()
                           {
                               Code = It.IsAny<string>(),
                           }
                       });
            //Act

            var result = await _pBill4PaidServiceController.GetPaymentInfo(localGetPaymentInfoRequest);

            //Assert

            Assert.NotNull(result.ThePBill4PaidInfoContract);
            Assert.NotNull(result.ThePBill4PaidInfoContract!.Desc);
            Assert.IsType(typeof(bool), result.ThePBill4PaidInfoContract.CanPay);
            Assert.IsType(typeof(string), result.ThePBill4PaidInfoContract.Desc);
            Assert.False(result.ThePBill4PaidInfoContract!.CanPay);
        }
        #endregion GetPaymentInfo


    }
}
