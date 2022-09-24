using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentListPendingComponent
    {

        IEnumerable<PGravamenInfoContract> gravoments;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                GetPersonPGravamenInfoContract _pGravamenInfoContract = new();

                PGravamenService pService = new();
                GetPersonPGravamensInfoRequest request = new();

                var pendingCode = new string[] { "000498", "000499", "000500", "000501", "000502", "000503", "000505", "000506" };
                string _AccessToken = await _localStorage.GetItemAsStringAsync(SharedInfo.AccessTokenKeyName);
                string _NationalCode = await _localStorage.GetItemAsStringAsync(SharedInfo.NationalCodeKeyName);

                var pendingGrvs = pService.GetGravamenListByNationalNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenListByNationalNo, _NationalCode, _AccessToken);
                this.gravoments = pendingGrvs.Where(a => pendingCode.Contains(a.TheObjectState.Code));

                //gravoments = gravoments.Where( a => a.TheObjectState.Code=="000499" || a.TheObjectState.Code=="000501" ||
                //                                    a.TheObjectState.Code=="000503" || a.TheObjectState.Code=="000498" ||
                //                                    a.TheObjectState.Code=="000500" || a.TheObjectState.Code=="000502" ||
                //                                    a.TheObjectState.Code=="000505" || a.TheObjectState.Code=="000506"  );
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);

            }
        }


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
