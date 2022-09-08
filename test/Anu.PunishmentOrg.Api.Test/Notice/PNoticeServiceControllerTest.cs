//using Anu.Commons.ServiceModel.ServicePaging;
//using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
//using Anu.PunishmentOrg.Api.Notice;
//using Anu.PunishmentOrg.DataModel.Notice;
//using Anu.PunishmentOrg.Domain.Notice;
//using Anu.PunishmentOrg.ServiceModel.Notice;
//using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
//using FluentAssertions;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Utility;
//using Xunit;

//namespace Anu.PunishmentOrg.Api.Test.Notice
//{
//    public class PNoticeServiceControllerTest
//    {
//        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();

//        [Fact]
//        public async Task InqueryPNoticeList_PNoticeIsNull_ReturenedError50002()
//        {
//            //Arrange
//            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(),
//                new Page() { PageNumber = 0, RowCountPerPage = 0, TotallPage = 0, TotalResult = 0, OrderPage = new OrderPage() { Property = "", Ascending = false } }))
//                .ReturnsAsync((IEnumerable<PNotice>)null);

//            var controller = new PNoticeServiceController(_unitOfWork.Object);

//            //Act

//            var result = controller.InqueryPNoticeList(
//                new ServiceModel.Notice.PNoticeInqueryRequest() { ThePNoticePersonContract = new PNoticePersonContract() { NationalityCode = "23232322" } });

//            //Assert
//            Assert.Equal((int)ExportPNoticeResult.PNotice_ExportPNotice_NotFound, result.Result.Result.Code);
//        }

//        [Fact]
//        public async Task InqueryPNoticeList_EnterNationalCode_ReturenedListOfNotices()
//        {
//            //Arrange
//            var expectedResponse = new PNoticeInqueryResponse()
//            {
//                ThePNoticeContractList = new Page<List<PNoticeContract>> { Data = new List<PNoticeContract>() { CreateRandomPNoticeContract("1"), CreateRandomPNoticeContract("2") } },
//                Result = AnuResult.Successful.GetResult()
//            };

//            _unitOfWork.Setup(repo => repo.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(It.IsAny<string>(), It.IsAny<Page>()))
//                .ReturnsAsync(new[] { CreateRandomPNotice("1"), CreateRandomPNotice("2") });


//            var controller = new PNoticeServiceController(_unitOfWork.Object);

//            //Act
//            var result = controller.InqueryPNoticeList(
//               new ServiceModel.Notice.PNoticeInqueryRequest()
//               {
//                   ThePNoticePersonContract = new PNoticePersonContract() { NationalityCode = "23232322" },
//                   Page =
//                new Page() { PageNumber = 0, RowCountPerPage = 0, TotallPage = 0, TotalResult = 0, OrderPage = new OrderPage() { Property = "", Ascending = false } }
//               });

//            //Assert
//            result.Should().BeEquivalentTo(expectedResponse,
//                options => options.ComparingByMembers<List<PNoticeContract>>().ExcludingMissingMembers());
//        }

//        private PNotice CreateRandomPNotice(string noPostFix)
//        {
//            return new PNotice()
//            {
//                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
//                No = $"140000000000000000{noPostFix}",
//                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
//                NoticePersonFamily = "km",
//                NoticePersonName = "soheil"
//            };
//        }

//        private PNoticeContract CreateRandomPNoticeContract(string noPostFix)
//        {
//            return new PNoticeContract()
//            {
//                CreateDateTime = DateTime.Now.ToString("yyyy/MM/dd"),
//                No = $"140000000000000000{noPostFix}",
//                NoticeDate = DateTime.Now.ToString("yyyy/MM/dd"),
//                NoticePersonFamily = "km",
//                NoticePersonName = "soheil"
//            };
//        }

//    }
//}
