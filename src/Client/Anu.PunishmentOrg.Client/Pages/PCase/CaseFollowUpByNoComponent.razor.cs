using Anu.PunishmentOrg.ServiceModel.Case;
using Microsoft.AspNetCore.Components;

namespace Anu.PunishmentOrg.Client.Pages.PCase
{
    public partial class CaseFollowUpByNoComponent
    {

        [Parameter]
        public string _CaseNo { get; set; }

        ExportInqueryPCaseResponse Elements;
        //

        protected override Task OnInitializedAsync()
        {
            GetCaseSummary();
            return base.OnInitializedAsync();
        }
        private async Task GetCaseSummary()
        {
            try
            {
                if (string.IsNullOrEmpty(_CaseNo) == false)
                    Elements = await _pCaseService.ExportInqueryPCase(_appConfiguration.BackendServerAddress, _appConfiguration.ExportInqueryPCase, SharedInfo.NationalCode, _CaseNo, SharedInfo.AccessToken);
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }
    }
}
