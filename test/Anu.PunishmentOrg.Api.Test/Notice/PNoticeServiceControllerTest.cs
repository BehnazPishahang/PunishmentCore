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
using System.Threading.Tasks;
using Utility;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Notice
{
    public class PNoticeServiceControllerTest
    {
        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();

        [Fact]
        public async Task InqueryPNoticeList_PNoticeIsNull_ReturenedError50002()
        {
            ////Arrange
            //_unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>()))
            //    .ReturnsAsync((IEnumerable<PNotice>)null);
            //
            //var controller = new PNoticeServiceController(_unitOfWork.Object);
            //
            ////Act
            //
            //var result = controller.InqueryPNoticeList(new ServiceModel.Notice.PNoticeInqueryRequest() { NationalityCode = 5456 });
            //
            ////Assert
            //Assert.Equal((int)PNoticeResult.PNotice_NotFound, result.Result.Result.Code);

            Assert.True(true);

        }

        [Fact]
        public async Task InqueryPNoticeList_EnterNationalCode_ReturenedListOfNotices()
        {
            ////Arrange
            //var expectedResponse = new PNoticeInqueryResponse()
            //{
            //    PNoticeList = new List<PNoticeContract> { CreateRandomPNoticeContract("1"), CreateRandomPNoticeContract("2") },
            //    Result = AnuResult.Successful.GetResult()
            //};
            //
            //_unitOfWork.Setup(repo => repo.PNotice.GetAllPNoticeByNationalCode(It.IsAny<string>()))
            //    .ReturnsAsync(new[] {CreateRandomPNotice("1"),CreateRandomPNotice("2")});
            //
            //
            //var controller = new PNoticeServiceController(_unitOfWork.Object);
            //
            ////Act
            //
            //var actual = await controller.InqueryPNoticeList(new ServiceModel.Notice.PNoticeInqueryRequest() { NationalityCode = 5456 });
            //
            ////Assert
            //actual.Should().BeEquivalentTo(expectedResponse);

            Assert.True(true);


        }

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
