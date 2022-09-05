using Anu.PunishmentOrg.ServiceModel.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.Client.Infrastructure.Contracts.Notice
{
    public interface INoticeService
    {
        public IEnumerable<PNoticeContract> getPNoticeList(String baseURl, string serviceName, string nationalCode);
        public string GetNoticePDF(String baseURl, string serviceName, string no);
        public ChangePNoticeViewByUserStatusResponse ChangePNoticeViewByUserStatus(String baseURl, string serviceName, string no);
        public GetCountOfUnSeenPNoticeByUserResponse GetCountOfUnSeenPNoticeByUser(String baseURl, string serviceName, string nationalCode);

        

    }

}
