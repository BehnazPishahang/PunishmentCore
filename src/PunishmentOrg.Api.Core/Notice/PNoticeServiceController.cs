
using Anu.BaseInfo.Enumerations;
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.DataModel.Case;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Domain.Notice;
using Anu.PunishmentOrg.Report;
using Anu.PunishmentOrg.ServiceModel.Case;
using Anu.PunishmentOrg.ServiceModel.Notice;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Report;
using Anu.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using Utility;
using Utility.CalendarHelper;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Notice
{
    public class PNoticeServiceController : PNoticeServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor

        public PNoticeServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<PNoticeInqueryResponse> InqueryPNoticeList([FromBody] PNoticeInqueryRequest request)
        {
            request.Null(InqueryPNoticeListResult.PNotice_InqueryPNoticeList_Request_Is_Required);

            request.PNoticePersonContract.Null(InqueryPNoticeListResult.PNotice_InqueryPNoticeList_ThePNoticePersonContract_Is_Required);

            request.PNoticePersonContract!.NationalityCode.NullOrWhiteSpace(InqueryPNoticeListResult.PNotice_InqueryPNoticeList_NationalityCode_Is_Required);

            var thePNoticeList = await _unitOfWork.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(request.PNoticePersonContract.NationalityCode!.Trim().ToString(), request.Page);

            thePNoticeList.Null(InqueryPNoticeListResult.PNotice_InqueryPNoticeList_NotFound);

            var thePNoticeContractList = thePNoticeList.Select(a => new PNoticeContract()
            {
                CreateDateTime     = a.CreateDateTime,
                No                 = a.No,
                NoticeDate         = a.NoticeDate,
                NoticePersonFamily = a.NoticePersonFamily,
                NoticePersonName   = a.NoticePersonName,
                ThePCase = new PCaseContract() 
                { 
                    No = a.ThePNoticePersonList.OfType<PNoticePerson>()?.FirstOrDefault()?.ThePCase?.No,
                }
            }
            ).ToList();

            return new PNoticeInqueryResponse
            {
                PNotice = new Page<List<PNoticeContract>> 
                { 
                    Paged = request.Page, 
                    Data  = thePNoticeContractList 
                },
                Result = AnuResult.Successful.GetResult()
            };
        }
        
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<ExportPNoticeResponse> ExportPNotice([FromBody] ExportPNoticeRequest request)
        {
            request.Null(ExportPNoticeResult.PNotice_ExportPNotice_Request_Is_Required);

            request.ThePNoticeNoInputContract.Null(ExportPNoticeResult.PNotice_ExportPNotice_ThePNoticeNoInputContract_Is_Required);

            request.ThePNoticeNoInputContract!.No.NullOrWhiteSpace(ExportPNoticeResult.PNotice_ExportPNotice_No_Is_Required);

            var thePNotice = await _unitOfWork.Repositorey<IPNoticeRepository>().GetPNoticeByNo(request.ThePNoticeNoInputContract.No!);

            thePNotice.Null(ExportPNoticeResult.PNotice_ExportPNotice_NotFound);

            thePNotice.Description.Null(ExportPNoticeResult.PNotice_ExportPNotice_Description_NotFound);

            PNoticeForStimul thePNoticeForStimul = this.GetPNoticeForStimul(thePNotice);

            return new ExportPNoticeResponse()
            {
                ThePNoticeExportContract = new PNoticeExportContract()
                {
                    Pdf = PunishmentOrgConstants.PNotice.PNoticePrint.ExportPdf("PNotice", thePNoticeForStimul)
                },
                Result = AnuResult.Successful.GetResult()
            };
        }

        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<ChangePNoticeViewByUserStatusResponse> ChangePNoticeViewByUserStatus([FromBody] ChangePNoticeViewByUserStatusRequest request)
        {
            #region Validation
            request.Null(ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_Request_Is_Required);
            request.ThePNoticeNoInputContract.Null(ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_ThePNoticeNoInputContract_Is_Required);
            request!.ThePNoticeNoInputContract!.No!.IsDigit(ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNoticeNo_Is_Required);
            request!.ThePNoticeNoInputContract!.No.NullOrWhiteSpace(ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNoticeNo_Is_Required);
            #endregion Validation

            var thePNotice = await _unitOfWork.Repositorey<IPNoticeRepository>().GetPNoticeByNo(request.ThePNoticeNoInputContract.No!);

            thePNotice.Null(ChangePNoticeViewByUserStatusResult.PNotice_ChangePNoticeViewByUserStatus_PNotice_NotFound);

            if (thePNotice.NoticeDate.NullOrWhiteSpace())
            {
                thePNotice.NoticeDate = DateTime.Now.ToPersian().ToString().Substring(0,10);
                thePNotice.IsViewedOnSite = YesNo.Yes;
                thePNotice.TheNoticeResultType = await _unitOfWork.Repositorey<Anu.BaseInfo.Domain.Types.INoticeResultTypeRepository>().
                    GetNoticeResultTypeWithCode(Anu.Constants.ServiceModel.BaseInfo.BaseInfoConstants.NoticeResultTypeCode.NotificationThroughTheSite);
            }

            _unitOfWork.Complete();

            return new ChangePNoticeViewByUserStatusResponse()
            {
                Result = AnuResult.Successful.GetResult()
            };
        }
        
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<GetCountOfUnSeenPNoticeByUserResponse> GetCountOfUnSeenPNoticeByUser([FromBody] GetCountOfUnSeenPNoticeByUserRequest request)
        {
            #region Validation
            request.Null(GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_Request_Is_Required);
            request.ThePNoticePersonContract.Null(GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_ThePNoticePersonContract_Is_Required);
            request!.ThePNoticePersonContract!.NationalityCode!.IsDigit(GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_NationalityCode_Is_Required);
            request!.ThePNoticePersonContract!.NationalityCode.NullOrWhiteSpace(GetCountOfUnSeenPNoticeByUserResult.PNotice_GetCountOfUnSeenPNoticeByUser_NationalityCode_Is_Required);
            #endregion Validation

            var thePNoticelistByUserNationalityCode = await _unitOfWork.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(request.ThePNoticePersonContract.NationalityCode!);

            return new GetCountOfUnSeenPNoticeByUserResponse()
            {
                Result = AnuResult.Successful.GetResult(),
                TheGetCountOfUnSeenPNoticeByUserContract = CountOfUnSeenPNoticeByUserCalculater(thePNoticelistByUserNationalityCode, request.ThePNoticePersonContract.NationalityCode)
            };
        }

        #endregion Overrides

        #region Methods

        private PNoticeForStimul GetPNoticeForStimul(PNotice thePNotice)
        {
            PNoticeForStimul thePNoticeForStimul = new PNoticeForStimul()
            {
                NoticeCreateDate = thePNotice.CreateDateTime?.Substring(0, 10),
                NoticeNo         = thePNotice.No,
                UnitName         = thePNotice.TheUnit?.UnitName,
                Address          = thePNotice.NoticePersonAddress,
                NoticeType       = thePNotice.TheGNoticeType?.Title,
                PersonAddress    = thePNotice.TheUnit?.Address,
                NoticeDate       = thePNotice.NoticeDate ?? CalendarHelper.GetCurrentDate(),
                Description      = thePNotice.Description.StripRichTextFormat(),
                CaseArchiveNo    = this.GetCaseArchiveNo(thePNotice),
                Violation        = this.GetViolation(thePNotice),
                PersonType       = this.GetPersonType(thePNotice),
                presenceTime     = this.GetPresenceTime(thePNotice),
                CaseNo           = this.GetCaseNo(thePNotice),
            };

            foreach (PNoticePerson PNoticePerson in thePNotice.ThePNoticePersonList)
            {
                if (PNoticePerson.ThePCasePerson != null)
                {
                    thePNoticeForStimul.PersonName         = PNoticePerson.ThePCasePerson.Name;
                    thePNoticeForStimul.PersonFamily       = PNoticePerson.ThePCasePerson.Family;
                    thePNoticeForStimul.PersonFatherName   = PNoticePerson.ThePCasePerson.FatherName;
                    thePNoticeForStimul.PersonNationalCode = PNoticePerson.ThePCasePerson.NationalCode;
                    thePNoticeForStimul.MobilNumber        = PNoticePerson.ThePCasePerson.MobilNumber;
                    thePNoticeForStimul.TradeUnitName      = PNoticePerson.ThePCasePerson.TradeUnitName;
                }
                if (PNoticePerson.TheExpertMan != null)
                {
                    thePNoticeForStimul.PersonName         = PNoticePerson.TheExpertMan.Name;
                    thePNoticeForStimul.PersonFamily       = PNoticePerson.TheExpertMan.Family;
                    thePNoticeForStimul.PersonFatherName   = PNoticePerson.TheExpertMan.FatherName;
                    thePNoticeForStimul.PersonNationalCode = PNoticePerson.TheExpertMan.NationalityCode;
                    thePNoticeForStimul.PhoneNumber        = PNoticePerson.TheExpertMan.Tel;
                    thePNoticeForStimul.MobilNumber        = PNoticePerson.TheExpertMan.MobileNumber4SMS;
                }
            }

            return thePNoticeForStimul;
        }

        private string GetViolation(PNotice thePNotice)
        {
            Collection<PBViolationType> HashViolation = new Collection<PBViolationType>();
            string violation = string.Empty;

            //foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
            //{
            //    if (onePNoticePerson.ThePCasePerson != null)
            //        foreach (PCaseViolation item in onePNoticePerson.ThePCasePerson.PersonViolationList)
            //        {
            //            if (!string.IsNullOrEmpty(item.ObjectId) && !HashViolation.Contains(item.ThePBViolationType))
            //                HashViolation.Add(item.ThePBViolationType);
            //        }
            //}

            foreach (PBViolationType item in HashViolation)
            {
                if (!string.IsNullOrWhiteSpace(violation))
                {
                    violation += " و ";
                }
                violation += item.Title;
            }

            return violation;
        }

        private string GetPersonType(PNotice thePNotice)
        {
            string personType = string.Empty;

            foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
            {
                if (onePNoticePerson.ThePCasePerson?.PersonType == PersonType.NaturalPerson)
                {
                    personType = "مشخصات ابلاغ شونده حقیقی";
                }
                else if (onePNoticePerson.ThePCasePerson?.PersonType == PersonType.Legal)
                {
                    personType = "مشخصات ابلاغ شونده حقوقی";
                }
            }

            return personType;
        }

        private string GetCaseArchiveNo(PNotice thePNotice)
        {
            string caseArchiveNo = string.Empty;

            foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
            {
                if (string.IsNullOrWhiteSpace(caseArchiveNo))
                {
                    caseArchiveNo += " و ";
                }
                caseArchiveNo += onePNoticePerson.ThePCase?.ArchiveNo; ;
            }

            return caseArchiveNo;
        }

        private string GetPresenceTime(PNotice thePNotice)
        {
            string presenceTime = string.Empty;

            if (thePNotice.InputStatistic != null)
            {
                presenceTime = thePNotice.InputStatistic + " روز پس از رویت";
            }
            if (thePNotice.PresenceDate != null)
            {
                presenceTime = "در تاریخ " + thePNotice.PresenceDate + " در ساعت " + thePNotice.PresenceTime;
            }

            return presenceTime;
        }

        private string GetCaseNo(PNotice thePNotice)
        {
            string caseNo = string.Empty;

            foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
            {
                if (!string.IsNullOrWhiteSpace(caseNo))
                {
                    caseNo += " و ";
                }

                caseNo += onePNoticePerson.ThePCase?.No;
            }

            return caseNo;
        }
        private GetCountOfUnSeenPNoticeByUserContract CountOfUnSeenPNoticeByUserCalculater(IEnumerable<Anu.PunishmentOrg.DataModel.Notice.PNotice> pNotices, string nationalityCode)
        {
            int TotalNoticeCount = 0;
            int UnSeenNoticeCount = 0;
            int SeenNoticeCount = 0;

            #region TotalNumberOfPersonNotice
            TotalNoticeCount = pNotices.Count();
            #endregion TotalNumberOfPersonNotice

            #region NumberOfUnSeenPersonNotice
            UnSeenNoticeCount = pNotices.Where(x => x.IsViewedOnSite == Anu.BaseInfo.Enumerations.YesNo.No || x.IsViewedOnSite == Anu.BaseInfo.Enumerations.YesNo.None
            || x.IsViewedOnSite == null && x.NoticeDate.NullOrWhiteSpace()).Count();
            #endregion NumberOfUnSeenPersonNotice

            #region NumberOfSeenPersonNotice
            SeenNoticeCount = TotalNoticeCount - UnSeenNoticeCount;
            #endregion NumberOfSeenPersonNotice

            return new GetCountOfUnSeenPNoticeByUserContract()
            {
                TotalCountPNoticeOfUser = TotalNoticeCount,
                CountSeenedOfPNoticeByUser = SeenNoticeCount,
                CountUnSeenPNoticeByUser = UnSeenNoticeCount,
                NoticePersonNationalityCode = nationalityCode,
            };
        }

        #endregion Methods
    }

    internal class PNoticeForStimul
    {
        public string NoticeNo { get; set; }
        public string NoticeDate { get; set; }
        public string NoticeCreateDate { get; set; }
        public string UnitName { get; set; }
        public string UserTitle { get; set; }
        public string Address { get; set; }
        public string NoticeType { get; set; }
        public string CaseNo { get; set; }
        public string AgentFullName { get; set; }
        public string NoticeText { get; set; }
        public string PersonName { get; set; }
        public string PersonFamily { get; set; }
        public string PersonFatherName { get; set; }
        public string PersonPostCode { get; set; }
        public string PersonNationalCode { get; set; }
        public string PersonAddress { get; set; }
        public string CaseArchiveNo { get; set; }
        public string SignPic { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilNumber { get; set; }
        public string Violation { get; set; }
        public string presenceTime { get; set; }
        public string TradeUnitName { get; set; }
        public string Description { get; set; }
        public string PersonType { get; set; }
    }
}