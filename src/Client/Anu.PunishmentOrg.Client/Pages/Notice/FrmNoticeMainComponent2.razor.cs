using Anu.PunishmentOrg.ServiceModel.Notice;
using MudBlazor;

namespace Anu.PunishmentOrg.Client.Pages.Notice
{
    public partial class FrmNoticeMainComponent2
    {
        private string _searchString;
        private bool _sortNameByLength;
        private List<string> _events = new();
       
        private IEnumerable<PNoticeContract> Elements;


     

        // custom sort by name length
        private Func<PNoticeContract, object> _sortBy => x =>
        {
            if (_sortNameByLength)
                return x.CreateDateTime.Length;
            else
                return x.CreateDateTime;
        };
        // quick filter - filter gobally across multiple columns with the same input
        private Func<PNoticeContract, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.CreateDateTime.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.No.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.NoticeDate} {x.NoticePersonFamily} {x.NoticePersonName}".Contains(_searchString))
                return true;

            return false;
        };

        // events
        void RowClicked(DataGridRowClickEventArgs<PNoticeContract> args)
        {
            _events.Insert(0, $"Event = RowClick, Index = {args.RowIndex}, Data = {System.Text.Json.JsonSerializer.Serialize(args.Item)}");
        }

        void SelectedItemsChanged(HashSet<PNoticeContract> items)
        {
            _events.Insert(0, $"Event = SelectedItemsChanged, Data = {System.Text.Json.JsonSerializer.Serialize(items)}");
        }

        void ShowPDF(PNoticeContract selectedRow)
        {
            try
            {
                string pdf = _noticeService.GetNoticePDF(_appConfiguration.BackendServerAddress, _appConfiguration.ExportPNotice, selectedRow.No, SharedInfo.AccessToken);

                var parameters = new DialogParameters();
                parameters.Add("showedPdfContent", pdf);
                parameters.Add("No", selectedRow.No);

                var options = new DialogOptions() { CloseButton = true, FullScreen = true };

                DialogService.Show<FrmNoticePrintComponent>("مشاهده ابلاغ", parameters, options);
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }

        }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                string ncode = SharedInfo.NationalCode;

                bool? ss = SharedInfo.LoadAllNoticeList;

                Elements = _noticeService.getPNoticeList(_appConfiguration.BackendServerAddress, _appConfiguration.InqueryPNoticeList, ncode, SharedInfo.AccessToken);

                if (SharedInfo.LoadAllNoticeList.HasValue && SharedInfo.LoadAllNoticeList.Value == true)
                    Elements = Elements.Where(t => !string.IsNullOrEmpty(t.NoticeDate));
                if (SharedInfo.LoadAllNoticeList.HasValue && SharedInfo.LoadAllNoticeList.Value == false)
                    Elements = Elements.Where(t => string.IsNullOrEmpty(t.NoticeDate));
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

    }



}

