using Anu.PunishmentOrg.Client.Infrastructure.Contracts.Notice;
using Anu.PunishmentOrg.Client.Infrastructure.Notice;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Microsoft.AspNetCore.Components;

namespace Anu.PunishmentOrg.Client.Pages.Notice
{
    public partial class FrmNoticeMainComponent
    {
       
        private IEnumerable<PNoticeContract> Elements;

       [Parameter]
        public string NationalCode { get; set; }
        public object OnNoticeSearch { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            string ncode = SharedInfo.NationalCode;
            Elements = _noticeService.getPNoticeList(_appConfiguration.BackendServerAddress, _appConfiguration.InqueryPNoticeList, ncode);
        }

    }
}
