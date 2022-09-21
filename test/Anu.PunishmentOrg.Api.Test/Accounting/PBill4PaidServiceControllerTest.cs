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

        #region GetPBill4PaidByFishNo

        [Fact]
        public async Task GetPBill4PaidByFishNo_RequestIsNull_ShouldReturn_Error30271()
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPBill4PaidByFishNoRequest = null;

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPBill4PaidByFishNoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_Request_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPBill4PaidByFishNo_PBill4PaidFishNoContractIsNull_ShouldReturn_Error30272()
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPBill4PaidByFishNoRequest = new GetPBill4PaidByFishNoRequest()
            { 
                ThePBill4PaidFishNoContract = null,
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPBill4PaidByFishNoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_ThePBill4PaidFishNoContract_Is_Required, exception.result.Code);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        [InlineData("test")]
        public async Task GetPBill4PaidByFishNo_FishNo_IsNull_Or_Invalid_ShouldReturn_Error30273(string fishNo)
        {
            //Arrange

            GetPBill4PaidByFishNoRequest localGetPBill4PaidByFishNoRequest = new GetPBill4PaidByFishNoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = fishNo,
                },
            };

            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPBill4PaidByFishNoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_FishNo_Is_Required, exception.result.Code);
        }

        [Fact]
        public async Task GetPBill4PaidByFishNo_PBill4Paid_NotFound_ShouldReturn_Error30274()
        {
            //Arrange
            GetPBill4PaidByFishNoRequest localGetPBill4PaidByFishNoRequest = new GetPBill4PaidByFishNoRequest()
            {
                ThePBill4PaidFishNoContract = new PBill4PaidFishNoContract()
                {
                    FishNo = "123"
                }
            };


            _unitOfWork.Setup(x => x.Repositorey<IPBill4PaidRepository>()
                                    .Get_PBill4PaidList_By_FishNo(It.IsAny<string>(), new Page()))
                       .ReturnsAsync((List<PBill4Paid>)null);
            //Act

            var exception = Assert.ThrowsAsync<AnuExceptions>(async () => await _pBill4PaidServiceController.GetPBill4PaidByFishNo(localGetPBill4PaidByFishNoRequest)).Result;

            //Assert

            Assert.Equal((int)GetPBill4PaidByFishNoResult.PBill4Paid_GetPBill4PaidByFishNo_PBill4Paid_NotFound, exception.result.Code);
        }

        #endregion GetPBill4PaidByFishNo


    }
}
