using Anu.PunishmentOrg.Client.Infrastructure.Notice;
using Anu.PunishmentOrg.ServiceModel.Notice;

namespace Anu.PunishmentOrg.Client.Pages.Notice
{
    public partial class FrmNoticeMainComponent
    {
        private IEnumerable<PNoticeContract> Elements;

        private void HandleNoticeSearch(string nationalcode)
        {
            Elements = NoticeService.getPNoticeList(nationalcode);
        }
    }
}
