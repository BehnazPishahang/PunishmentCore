using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using MudBlazor;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentListComponent
    {

        IEnumerable<PGravamenInfoContract> gravoments;

        protected override async Task OnInitializedAsync()
        {

            Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
         
            try
            {
                GetPersonPGravamenInfoContract _pGravamenInfoContract = new();

                PGravamenService pService = new();
                GetPersonPGravamensInfoRequest request = new();
                string _AccessToken = await _localStorage.GetItemAsStringAsync(SharedInfo.AccessTokenKeyName);
                string _NationalCode = await _localStorage.GetItemAsStringAsync(SharedInfo.NationalCodeKeyName);
                var grvList = pService.GetGravamenListByNationalNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenListByNationalNo, _NationalCode, _AccessToken);
                this.gravoments = grvList;
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }
        //protected override void OnInitialized()
        //{
        //    Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
        //    base.OnInitialized();
        //    try
        //    {
        //        GetPersonPGravamenInfoContract _pGravamenInfoContract = new();

        //        PGravamenService pService = new();
        //        GetPersonPGravamensInfoRequest request = new();

        //        var grvList = pService.GetGravamenListByNationalNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenListByNationalNo, SharedInfo.NationalCode, SharedInfo.AccessToken);
        //        this.gravoments = grvList;
        //    }
        //    catch
        //    {
        //        Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
        //    }
        //}


        private void GravamneSummary(PGravamenInfoContract contex)
        {
            _navigationManager.NavigateTo($"/GranovmentSummary/{contex.FollowUpNo}");
        }

        private string _searchString;

        private Func<PGravamenInfoContract, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.FollowUpNo.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;


            return false;
        };

    }
}
