using Anu.Commons.ServiceModel.SeviceRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    public class PNoticeExportRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public PNoticeNoInput PNoticeNoContract { get; set; }

        public PNoticeExportRequest()
        {
            Request = new Request();
            PNoticeNoContract = new PNoticeNoInput();
        }

    }
}
