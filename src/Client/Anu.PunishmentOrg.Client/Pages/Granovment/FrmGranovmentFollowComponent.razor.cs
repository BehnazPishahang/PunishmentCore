using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentFollowComponent
    {
        string CaseNo { set; get; }
        PGravamenContract? _pGravamenContract;

        private void GetGranovmentSummary()
        {
            try
            {
                _pGravamenContract = null;
                PGravamenByIdContract _pGravamenByIdContract = new();
                _pGravamenByIdContract.FollowUpNo = CaseNo;

                PGravamenService pService = new();
                GetPGravamenByIdRequest request = new();
                request.ThePGravamenByIdContract = _pGravamenByIdContract;
                GetPGravamenByIdResponse response = pService.GetGravamenByFollowingNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenByFollowingNo, request);
                if (response.Result.Code == 1000)
                    _pGravamenContract = response.ThePGravamenContract;

                if (_pGravamenContract == null)
                {
                    Snackbar.Add("با شماره شکوائیه وارد شده اطلاعاتی وجود ندارد", MudBlazor.Severity.Error);
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
