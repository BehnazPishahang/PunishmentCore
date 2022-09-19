using Anu.Commons.ServiceModel.SeviceRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    public class ExportPNoticeRequest : IRequestMessage
    {
        public Request Request { get; set; }
        public PNoticeNoInput ThePNoticeNoContract { get; set; }

        public ExportPNoticeRequest()
        {
            Request = new Request();
            ThePNoticeNoContract = new PNoticeNoInput();
        }

    }
}
