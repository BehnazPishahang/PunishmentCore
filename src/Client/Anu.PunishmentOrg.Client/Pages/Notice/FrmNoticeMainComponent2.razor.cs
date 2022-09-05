﻿using Anu.PunishmentOrg.ServiceModel.Notice;
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
            string  pdf = _noticeService.GetNoticePDF(_appConfiguration.BackendServerAddress, _appConfiguration.ExportPNotice, selectedRow.No);

            var parameters = new DialogParameters();
            parameters.Add("showedPdfContent",pdf);
            

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.Large };

            DialogService.Show<FrmNoticePrintComponent>("Delete", parameters, options);
        }
        protected override async Task OnInitializedAsync()
        {
            string ncode = SharedInfo.NationalCode;
            Elements = _noticeService.getPNoticeList(_appConfiguration.BackendServerAddress, _appConfiguration.InqueryPNoticeList, ncode);
        }

    }



}

