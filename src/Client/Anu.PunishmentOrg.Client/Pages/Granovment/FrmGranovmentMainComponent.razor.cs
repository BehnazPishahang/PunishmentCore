using Anu.BaseInfo.Enumerations;
using Anu.BaseInfo.ServiceModel.Attachment;
using Anu.BaseInfo.ServiceModel.GeoInfo;
using Anu.PunishmentOrg.Client.Infrastructure.Granovment;
using Anu.PunishmentOrg.ServiceModel.Gravamen;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using Newtonsoft.Json;

namespace Anu.PunishmentOrg.Client.Pages.Granovment
{
    public partial class FrmGranovmentMainComponent
    {
        // متغیرها
        #region variables
        string uploadedFileInfo { set; get; } = "";
        public bool AcceptInfo { get; set; } = false;
        string StringValue { set; get; } = "";
        GeoLocationContract selectedState, selectedProvince;
        List<GeoLocationContract> States = new();
        List<GeoLocationContract> province = new();
        List<PGravamenPersonContract> reporters = new();
        List<PGravamenPersonContract> accusers = new();
        List<GAttachmentContract> attachments = new();
        PGravamenPersonContract _reporter = new();
        PGravamenPersonContract _accuser = new();
        PGravamenPersonContract _selectedAccuser;
        PGravamenContract _pGravamenContract = new();
        GAttachmentContract _attachment = new();
        private List<string> _events = new();
        MudForm form, FormReporter, Formaccuser, Formattachment;
        private MudTable<PGravamenPersonContract> mudTable;
        private MudTable<PGravamenPersonContract> mudTableaccuser;
        private MudTable<GAttachmentContract> mudTableAttach;
        private string[] reason = { "گران فروشی", "کم فروشی", "عدم درج قیمت", "تقلب در کسب", "عدم صدور صورتحساب (فاکتور)" };
        private int selectedRowNumber = -1;
        string contentType;
        bool validfilesize = true;
        #endregion

        //
        #region main

        private void OpenDialog()
        {
            //CloseOnEscapeKey = true ,
            var options = new DialogOptions { CloseOnEscapeKey = false, DisableBackdropClick = true, MaxWidth = MaxWidth.Medium, FullWidth = true };
            DialogService.Show<GranovmentLawDialog>("", options);
        }

        protected override void OnInitialized()
        {
            try
            {
                base.OnInitialized();
                GeoLocationRequest input = new();
                GeoLocationContract GeoContract = new();
                GeoContract.ChildLocationType = BaseInfo.Enumerations.LocationType.State;
                GeoContract.LocationCode = "002";
                input.TheGeoLocationContract = GeoContract;
                States = _geoLoactionService.GetProvicesList(_appConfiguration.BackendServerAddress, _appConfiguration.GetGeoLocationList, input);
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
                OpenDialog();
        }


        private void Statevaluechanged()
        {
            try
            {
                if (selectedState != null)
                {
                    GeoLocationRequest input = new();
                    GeoLocationContract GeoContract = new();
                    GeoContract.ChildLocationType = BaseInfo.Enumerations.LocationType.Province;
                    GeoContract.LocationCode = selectedState.LocationCode;
                    input.TheGeoLocationContract = GeoContract;
                    province = _geoLoactionService.GetProvicesList(_appConfiguration.BackendServerAddress, _appConfiguration.GetGeoLocationList, input);
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

        private void SaveGranovment()
        {
            try
            {
                //form.Validate();
                if (!isFormValid())
                    return;

                _pGravamenContract.ThePGravamenPersonContractList.Clear();
                _pGravamenContract.ThePGravamenPersonContractList.Clear();
                _pGravamenContract.TheGAttachmentContractList.Clear();

                _pGravamenContract.GravamenOrReport = Enumerations.GravamenOrReport.Gravamen;
                _pGravamenContract.HowDataType = Enumerations.PU135OrWebSite.WebSite;
                _pGravamenContract.ThePGravamenPersonContractList.AddRange(reporters);
                _pGravamenContract.ThePGravamenPersonContractList.AddRange(accusers);
                _pGravamenContract.TheGAttachmentContractList.AddRange(attachments);
                _pGravamenContract.TheGeoLocationContract = selectedProvince;
                _pGravamenContract.PetitionReasons = _pGravamenContract.PetitionSubject;
                _pGravamenContract.NoticeText = "nothing";
                _pGravamenContract.RejectReasonText = "nothing";
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(_pGravamenContract, Formatting.Indented);
                PGravamenServiceRequest pGravamenRequest = new PGravamenServiceRequest();
                pGravamenRequest.ThePGravamenContract = _pGravamenContract;
                PGravamenService pService = new();
                PGravamenServiceResponse pGravamenrespons = pService.RecieveGravamen(_appConfiguration.BackendServerAddress, _appConfiguration.RecieveGravamen, pGravamenRequest);
                if (pGravamenrespons.Result.Code == 1000)
                {
                    string strMessage = "درخواست شما با شماره پیگیری " + pGravamenrespons.ThePGravamenResponseContract.FollowUpNo + "در سامانه ثبت گردید";
                    Snackbar.Add(strMessage, MudBlazor.Severity.Success);
                    _pGravamenContract = new();
                    _accuser = new PGravamenPersonContract();
                    _attachment = new GAttachmentContract();
                    reporters.Clear();
                    accusers.Clear();
                    attachments.Clear();
                    _navigationManager.NavigateTo($"/GranovmentSummary/{pGravamenrespons.ThePGravamenResponseContract.FollowUpNo}");

                }
                else
                {
                    Snackbar.Add(pGravamenrespons.Result.Message + " " + pGravamenrespons.Result.Code, MudBlazor.Severity.Error);
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }


        private bool isFormValid()
        {
            bool result = true;

            Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomLeft;

            if (selectedProvince == null)
            {
                Snackbar.Add("شهرتان را انتخاب نمایید ", MudBlazor.Severity.Error);
                result = false;
            }

            if (selectedState == null)
            {
                Snackbar.Add("استان را انتخاب نمایید ", MudBlazor.Severity.Error);
                result = false;
            }

            if (string.IsNullOrEmpty(_pGravamenContract.PetitionDescription))
            {
                Snackbar.Add("اطلاعات شکواییه را وارد نمایید  ", MudBlazor.Severity.Error);
                result = false;
            }
            if (string.IsNullOrEmpty(_pGravamenContract.PetitionSubject))
            {
                Snackbar.Add("موضوع  شکواییه را وارد نمایید  ", MudBlazor.Severity.Error);
                result = false;
            }



            if (accusers.Count == 0)
            {
                Snackbar.Add("اطلاعات  متهم را وارد نمایید.", MudBlazor.Severity.Error);
                result = false;

            }



            if (reporters.Count == 0)
            {
                Snackbar.Add("اطلاعات  شاکی  را وارد نمایید.", MudBlazor.Severity.Error);
                result = false;
            }

            if (attachments.Count == 0)
            {
                Snackbar.Add("مدارک پیوست را بارگزاری نمایید ", MudBlazor.Severity.Error);
                result = false;

            }

            return result;
        }
        #endregion
        //شاکی/شاکیان
        #region reporter

        private void AddReporter()
        {
            try
            {
                FormReporter.Validate();

                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomLeft;
                if (FormReporter.Errors.Count() > 0)
                {
                    foreach (string str in FormReporter.Errors)
                    {
                        Snackbar.Add(str, MudBlazor.Severity.Error);
                    }
                    SimulateProgress();
                }

                if (FormReporter.IsValid)
                {
                    if (CheckValidation())
                    {
                        _reporter.Nationality = LNationality.Iranian;
                        _reporter.PersonType = PersonType.NaturalPerson;
                        _reporter.PersonPassword = "Aa123";
                        _reporter.PersonStartPost = Enumerations.PUPersonStartPost.PlaintiffPerson;
                        _reporter.TradeUnitName = "";
                        reporters.Add(_reporter);
                        _reporter = new PGravamenPersonContract();
                    }
                    else
                    {
                        Snackbar.Add(strValidation, MudBlazor.Severity.Error);
                    }
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

        bool validReporterData = true;
        string strValidation;
        private bool CheckValidation()
        {
            if (_reporter.NationalCode.Length != 10)
            {
                strValidation = "شماره ملی باید 10 رقمی باشد";
                validReporterData = false;
                return validReporterData;
            }

            if(_reporter.MobilNumber.Length != 11)
            {
                strValidation = "شماره همراه باید 11 رقمی باشد";
                validReporterData = false;
                return validReporterData;
            }

            if (_reporter.MobilNumber.StartsWith("09") == false)
            {
                strValidation = "شماره همراه را بدرستی وارد نمایید";
                validReporterData = false;
                return validReporterData;
            }

            return validReporterData;
        }


        void EditReporter(PGravamenPersonContract selectedPGravamenPersonContractForEdit)
        {
            _reporter = selectedPGravamenPersonContractForEdit;
            reporters.Remove(_reporter);
        }



        void RemoveReporter(PGravamenPersonContract selectedPGravamenPersonContractForDelete)
        {
            reporters.Remove(selectedPGravamenPersonContractForDelete);
        }

        private string ReporterSelectedRowClassFunc(PGravamenPersonContract element, int rowNumber)
        {
            if (selectedRowNumber == rowNumber)
            {
                selectedRowNumber = -1;
                return string.Empty;
            }
            else if (mudTable.SelectedItem != null && mudTable.SelectedItem.Equals(element))
            {
                selectedRowNumber = rowNumber;
                return "selected";
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion

        //متهم / متهمان
        #region accuser
        private void Addaccuser()
        {
            try
            {
                Formaccuser.Validate();

                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomLeft;
                if (Formaccuser.Errors.Count() > 0)
                {
                    foreach (string str in Formaccuser.Errors)
                    {
                        Snackbar.Add(str, MudBlazor.Severity.Error);
                    }
                    SimulateProgress();
                }

                if (Formaccuser.IsValid)
                {
                    _accuser.PersonStartPost = Enumerations.PUPersonStartPost.OffendingPerson;
                    _accuser.TradeUnitName = _accuser.Name;
                    accusers.Add(_accuser);
                    _accuser = new PGravamenPersonContract();
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }
        private void Removeaccuser(PGravamenPersonContract selectedItem)
        {
            accusers.Remove(selectedItem);
        }
        private void Editaccuser(PGravamenPersonContract selectedItem)
        {
            _accuser = selectedItem;
            accusers.Remove(_accuser);
        }

        private string accuserSelectedRowClassFunc(PGravamenPersonContract element, int rowNumber)
        {
            if (selectedRowNumber == rowNumber)
            {
                selectedRowNumber = -1;
                return string.Empty;
            }
            else if (mudTable.SelectedItem != null && mudTableaccuser.SelectedItem.Equals(element))
            {
                selectedRowNumber = rowNumber;
                return "selected";
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion

        //مدارک و مستندات
        #region attachment
        private void Addattachment()
        {
            try
            {
                Formattachment.Validate();
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomLeft;
                if (Formattachment.Errors.Count() > 0)
                {
                    foreach (string str in Formattachment.Errors)
                    {
                        Snackbar.Add(str, MudBlazor.Severity.Error);
                    }
                    SimulateProgress();
                }
                if (validfilesize)
                {
                    if (Formattachment.IsValid)
                    {
                        _attachment.PathAndFileName = uploadedFileInfo;

                        GAttachmentDataContract gattachDataContract = new();
                        gattachDataContract.DocFile = uploadedFile;
                        _attachment.SecondMili = contentType;
                        _attachment.TheGAttachmentDataContract = gattachDataContract;

                        attachments.Add(_attachment);
                        uploadedFileInfo = "";
                        _attachment = new();
                    }
                }
                else
                {
                    _attachment = new();
                    validfilesize = true;
                    Snackbar.Add("حجم فایل نباید بیشتر از 200 کیلو بایت باشد", MudBlazor.Severity.Error);
                }
            }
            catch
            {
                Snackbar.Add(SharedInfo.strPublicError, MudBlazor.Severity.Error);
            }
        }

        private void Removeattachment(GAttachmentContract context)
        {
            attachments.Remove(context);
        }

        private async Task Downloadattachment(GAttachmentContract context)
        {
            //"application/octet-stream"
            await BlazorDownloadFileService.DownloadFile(context.Title, context.TheGAttachmentDataContract.DocFile, context.SecondMili);
        }


        byte[] uploadedFile;
        private async Task UploadFiles(InputFileChangeEventArgs e)
        {
            if (e.File.Size <= 200000)
            {
                long size = e.File.Size;
                contentType = e.File.ContentType;
                uploadedFileInfo = e.File.Name;
                MemoryStream ms = new MemoryStream();
                await e.File.OpenReadStream().CopyToAsync(ms);
                uploadedFile = ms.ToArray();
            }
            else
            {
                validfilesize = false;
            }
        }

        #endregion

        //اطلاع رسانی
        #region Snacker
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
                await Task.Delay(500);

            } while (ProgressValue > 0);

            StateHasChanged();
        }
        #endregion
    }
}
