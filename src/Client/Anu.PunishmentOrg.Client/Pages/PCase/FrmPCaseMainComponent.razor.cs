using Anu.PunishmentOrg.ServiceModel.Case;
using MudBlazor;

namespace Anu.PunishmentOrg.Client.Pages.PCase
{
    public partial class FrmPCaseMainComponent
    {
        private string _searchString;
        private bool _sortNameByLength;
        private List<string> _events = new();

        private IEnumerable<GetAllPCaseContract> Elements;


        // custom sort by name length
        private Func<GetAllPCaseContract, object> _sortBy => x =>
        {
            if (_sortNameByLength)
                return x.CreateDateTime.Length;
            else
                return x.CreateDateTime;
        };
        // quick filter - filter gobally across multiple columns with the same input
        private Func<GetAllPCaseContract, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.CreateDateTime.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.No.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.No} {x.UnitName} {x.CreateDateTime}".Contains(_searchString))
                return true;

            return false;
        };

        // events
        void RowClicked(DataGridRowClickEventArgs<GetAllPCaseContract> args)
        {
            _events.Insert(0, $"Event = RowClick, Index = {args.RowIndex}, Data = {System.Text.Json.JsonSerializer.Serialize(args.Item)}");
        }

        void SelectedItemsChanged(HashSet<GetAllPCaseContract> items)
        {
            _events.Insert(0, $"Event = SelectedItemsChanged, Data = {System.Text.Json.JsonSerializer.Serialize(items)}");
        }
    
        void ShowDetail(GetAllPCaseContract selectedRow)
        {
            _navigationManager.NavigateTo($"/CaseFollowUpNo/{selectedRow.No}");
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {

                bool? ss = SharedInfo.LoadAllNoticeList;
                string _AccessToken = await _localStorage.GetItemAsStringAsync(SharedInfo.AccessTokenKeyName);
                string _NationalCode = await _localStorage.GetItemAsStringAsync(SharedInfo.NationalCodeKeyName);
                Elements = _pCaseService.getPCaseList(_appConfiguration.BackendServerAddress, _appConfiguration.GetAllPCase, _NationalCode, _AccessToken);
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }

        }
    }
}
