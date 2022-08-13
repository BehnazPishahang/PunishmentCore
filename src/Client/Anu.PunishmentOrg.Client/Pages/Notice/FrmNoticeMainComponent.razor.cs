using Anu.PunishmentOrg.Client.Infrastructure.Notice;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Microsoft.AspNetCore.Components;

namespace Anu.PunishmentOrg.Client.Pages.Notice
{
    public partial class FrmNoticeMainComponent
    {
        private IEnumerable<PNoticeContract> Elements;

        private void HandleNoticeSearch(string nationalcode)
        {
            Elements = NoticeService.getPNoticeList(nationalcode);
        }
  

    [Parameter]
    public string NationalCode { get; set; }
        public object OnNoticeSearch { get; private set; }

        protected override   void OnInitialized ()
        {

            //Elements = NoticeService.getPNoticeList(NationalCode);

            IList<PNoticeContract> getPNoticeList = new List<PNoticeContract> ();
            PNoticeContract notice = new PNoticeContract();
            notice.NoticeDate = "1400/01/001";
            notice.NoticePersonName = "ali";
            notice.NoticePersonFamily = "nemati";
            notice.CreateDateTime = "1400/01/001";

            getPNoticeList.Add(notice);
            getPNoticeList.Add(notice);
            getPNoticeList.Add(notice);
            Elements = getPNoticeList;
            //return await  ;
        }

    }
}
