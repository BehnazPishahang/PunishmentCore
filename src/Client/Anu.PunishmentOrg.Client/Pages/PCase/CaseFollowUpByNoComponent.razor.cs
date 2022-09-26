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

        protected override async Task OnInitializedAsync()
        {
            string _AccessToken =  await _localStorage.GetItemAsStringAsync(SharedInfo.AccessTokenKeyName);
            string _NationalCode =  await _localStorage.GetItemAsStringAsync(SharedInfo.NationalCodeKeyName);
            await GetCaseSummary(_AccessToken, _NationalCode);
        }
        private async Task GetCaseSummary(string accessToken ,string nationalCode)
        {
            try
            {
                if (string.IsNullOrEmpty(_CaseNo) == false)
                    Elements = await _pCaseService.ExportInqueryPCase(_appConfiguration.BackendServerAddress, _appConfiguration.ExportInqueryPCase, nationalCode, _CaseNo, accessToken);
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }
    }
}
