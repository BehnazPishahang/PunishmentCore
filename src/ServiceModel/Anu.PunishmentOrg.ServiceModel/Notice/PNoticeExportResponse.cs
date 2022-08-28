using Anu.Commons.ServiceModel.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    public class PNoticeExportResponse : IResponseMessage
    {
        public Result Result { get; set; }

        public PNoticeExportContract PNotice { get; set; }

        public PNoticeExportResponse()
        {
            Result = new Result();
            PNotice = new PNoticeExportContract();
        }

    }
}
