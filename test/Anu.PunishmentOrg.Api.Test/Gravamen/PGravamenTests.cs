using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Gravamen
{
    public class PGravamenTests
    {
        private readonly Mock<Anu.DataAccess.IUnitOfWork> _unitOfWork = new();
        private 
        //SetUp
        public PGravamenTests()
        {
            _unitOfWork.Setup(repo => repo..GetAllPNoticeByNationalCode(It.IsAny<string>()))
                .ReturnsAsync((IEnumerable<PNotice>)null);

            var controller = new PNoticeServiceController(_unitOfWork.Object);
        }

        [Fact]
        public void RecieveGravamen_WhenCalled_ShouldReturnSuccusfulResult()
        {

        }
    }
}
