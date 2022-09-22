using Anu.PunishmentOrg.ServiceModel.Case;
using MudBlazor;

namespace Anu.PunishmentOrg.Client.Pages.PCase
{
    public partial class CaseFollowUpComponent
    {

        string CaseNo { set; get; }
        string NationalNo { set; get; }
        ExportInqueryPCaseResponse Elements;

        private async Task GetCaseSummary()
        {
            try
            {
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;

                if (string.IsNullOrEmpty(CaseNo) == false)
                    Elements = await _pCaseService.ExportInqueryPCase(_appConfiguration.BackendServerAddress, _appConfiguration.ExportInqueryPCase, SharedInfo.NationalCode, CaseNo, SharedInfo.AccessToken);

                if (Elements.Result.Code == -770003)
                {
                    Snackbar.Add("با شماره پرونده وارد شده اطلاعاتی وجود ندارد", MudBlazor.Severity.Error);
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

        bool _disposed;
        public void Dispose() => _disposed = true;
        private int ProgressValue { get; set; }
        public async void SimulateProgress()
        {
            ProgressValue = 120;
            do
            {
                if (_disposed)
                {
                    return;
                }

                ProgressValue -= 1;
                StateHasChanged();
                await Task.Delay(1000);

            } while (ProgressValue > 0);

            StateHasChanged();
        }

    }
}
