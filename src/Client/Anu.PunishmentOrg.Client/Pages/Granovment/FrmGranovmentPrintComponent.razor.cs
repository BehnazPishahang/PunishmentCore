using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Microsoft.AspNetCore.Components;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentPrintComponent
    {
        [Parameter]
        public string _pGravamen { get; set; }

        PGravamenContract? _pGravamenContract;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            try
            {
                PGravamenByIdContract _pGravamenByIdContract = new();
                _pGravamenByIdContract.FollowUpNo = _pGravamen;

                PGravamenService pService = new();
                GetPGravamenByIdRequest request = new();
                request.ThePGravamenByIdContract = _pGravamenByIdContract;
                GetPGravamenByIdResponse response = pService.GetGravamenByFollowingNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenByFollowingNo, request);
                if (response.Result.Code == 1000)
                    _pGravamenContract = response.ThePGravamenContract;
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }
    }
}
