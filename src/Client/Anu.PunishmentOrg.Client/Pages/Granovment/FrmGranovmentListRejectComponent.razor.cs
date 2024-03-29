﻿using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentListRejectComponent
    {
        IEnumerable<PGravamenInfoContract> gravoments;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                GetPersonPGravamenInfoContract _pGravamenInfoContract = new();

                PGravamenService pService = new();

                var rejectCode = new string[] { "000497", "000504" };
                string _AccessToken = await _localStorage.GetItemAsStringAsync(SharedInfo.AccessTokenKeyName);
                string _NationalCode = await _localStorage.GetItemAsStringAsync(SharedInfo.NationalCodeKeyName);
                var rejectGrvs = pService.GetGravamenListByNationalNo(_appConfiguration.BackendServerAddress, _appConfiguration.GetGravamenListByNationalNo, _NationalCode, _AccessToken);
                this.gravoments = rejectGrvs.Where(a => rejectCode.Contains(a.TheObjectState.Code));
                //this.gravoments = rejectGrvs.Where(a => a.TheObjectState.Code == "000497" || a.TheObjectState.Code == "000504");
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
