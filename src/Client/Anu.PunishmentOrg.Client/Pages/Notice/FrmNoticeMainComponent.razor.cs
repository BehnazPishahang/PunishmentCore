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

        protected override async Task OnInitializedAsync()
        {
            
            Elements = NoticeService.getPNoticeList(NationalCode);
        }

    }
}
