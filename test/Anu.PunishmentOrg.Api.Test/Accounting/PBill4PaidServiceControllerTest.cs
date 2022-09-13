using Anu.Commons.ServiceModel.ServicePaging;
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

        #region GetPBill4PaidListByFishNo

        [Fact]
        public async Task GetPaymentInfo_RequestIsNull_ShouldReturn_Error30271()
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPaymentInfoRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_Request_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_PBill4PaidFishNoContractIsNull_ShouldReturn_Error30272()
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPaymentInfoRequest = new GetPBill4PaidByFishNoRequest()
            { 
                ThePBill4PaidFishNoContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_ThePBill4PaidFishNoContract_Is_Required, exception.result.Code);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        [InlineData("test")]
        public async Task GetPaymentInfo_FishNo_IsNull_Or_Invalid_ShouldReturn_Error30273(string fishNo)
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPaymentInfoRequest = new GetPBill4PaidByFishNoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = fishNo,
                },
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPaymentInfoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_FishNo_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPaymentInfo_PBill4Paid_NotFound_ShouldReturn_Error30274()
        {
            //Arrange
            GetPaymentInfoRequest localGetPaymentInfoRequest = new GetPaymentInfoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = "123"
                }
            };

        //    _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
        //                            .Get_PBill4PaidList_By_FishNo(It.IsAny<string>()))
        //               .ReturnsAsync((PBill4Paid)null);
        //    //Act

        //    var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidListByFishNo(localGetPaymentInfoRequest)).Result;

        //    //Assert

        //    Assert.Equal((int)GetPBill4PaidListByFishNoResult.PBill4Paid_GetPBill4PaidListByFishNo_PBill4Paid_NotFound, exception.result.Code);
        //}

        //[Theory]
        //[InlineData(PBill4Cash.Confirmed, true)]
        //[InlineData(PBill4Cash.Paid, false)]
        //public async Task GetPaymentInfo_When_State_Is_InputState_Then_OutputCanPay_Should_Be_Returned(string inputState, bool outputCanPay)
        //{
        //    //Arrange

        //    GetPBill4PaidListByFishNoRequest localGetPaymentInfoRequest = new GetPBill4PaidListByFishNoRequest()
        //    {
        //        ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
        //        {
        //            FishNo = "123"
        //        }
        //    };

        //    _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
        //                            .Get_PBill4PaidList_By_FishNo(It.IsAny<string>(), new Page() 
        //                            {
        //                            OrderPage
                                    
        //                            }))
        //               .ReturnsAsync(new PBill4Paid()
        //               { 
        //                    TheObjectState = new()
        //                    { 
        //                        Code = inputState,
        //                    }
        //               });
        //    //Act

        //    var result = await _pBill4PaidServiceController.GetPBill4PaidListByFishNo(localGetPaymentInfoRequest);

        //    //Assert

        //    Assert.NotNull(result.ThePBill4PaidInfoContract);
        //    //Assert.NotNull(result.ThePBill4PaidInfoContract!.Desc);
        //    //Assert.IsType(typeof(bool), result.ThePBill4PaidInfoContract.CanPay);
        //    //Assert.IsType(typeof(string), result.ThePBill4PaidInfoContract.Desc);
        //    //Assert.Equal(outputCanPay, result.ThePBill4PaidInfoContract.CanPay);
        //}

        //[Fact]
        //public async Task GetPaymentInfo_State_NotConfirmed_ShouldReturn__CanPay_False()
        //{
        //    //Arrange

        //    GetPBill4PaidListByFishNoRequest localGetPaymentInfoRequest = new GetPBill4PaidListByFishNoRequest()
        //    {
        //        ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
        //        {
        //            FishNo = "123"
        //        }
        //    };

        //    _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
        //                            .Get_PBill4PaidList_By_FishNo(It.IsAny<string>()))
        //               .ReturnsAsync(new PBill4Paid()
        //               {
        //                   TheObjectState = new()
        //                   {
        //                       Code = It.IsAny<string>(),
        //                   }
        //               });
        //    //Act

        //    var result = await _pBill4PaidServiceController.GetPBill4PaidListByFishNo(localGetPaymentInfoRequest);

        //    //Assert

        //    Assert.NotNull(result.ThePBill4PaidInfoContract);
        //    Assert.NotNull(result.ThePBill4PaidInfoContract!.Desc);
        //    Assert.IsType(typeof(bool), result.ThePBill4PaidInfoContract.CanPay);
        //    Assert.IsType(typeof(string), result.ThePBill4PaidInfoContract.Desc);
        //    Assert.False(result.ThePBill4PaidInfoContract!.CanPay);
        //}
        #endregion GetPBill4PaidListByFishNo


    }
}
