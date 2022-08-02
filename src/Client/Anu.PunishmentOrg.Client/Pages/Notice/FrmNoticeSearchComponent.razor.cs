using Microsoft.AspNetCore.Components;

namespace Anu.PunishmentOrg.Client.Pages.Notice
{
    public partial class FrmNoticeSearchComponent
    {
        public string NationalCode { get; set; }

        [Parameter]
        public EventCallback<string> OnNoticeSearch { get; set; }
        private void HandleSearch()
        {
            if (NationalCode!.Length != 10)
            {
                return;
            }
            OnNoticeSearch.InvokeAsync(NationalCode);
        }
    }
}
