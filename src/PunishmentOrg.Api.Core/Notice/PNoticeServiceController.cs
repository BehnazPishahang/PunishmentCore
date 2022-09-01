
using Anu.BaseInfo.Enumerations;
using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Domain;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.DataModel.Case;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Domain.Notice;
using Anu.PunishmentOrg.Report;
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
            request.Null(InqueryPNoticeListResult.PNotice_GetPNoticeByNationalityCode_Request_Is_Required);

            request.ThePNoticePersonContract.Null(InqueryPNoticeListResult.PNotice_GetPNoticeByNationalityCode_ThePNoticePersonContract_Is_Required);

            request.ThePNoticePersonContract!.NationalityCode.NullOrWhiteSpace(InqueryPNoticeListResult.PNotice_GetPNoticeByNationalityCode_NationalityCode_Is_Required);

            var thePNoticeList = await _unitOfWork.Repositorey<IPNoticeRepository>().GetAllPNoticeByNationalCode(request.ThePNoticePersonContract.NationalityCode!.Trim().ToString(), request.Page);

            thePNoticeList.Null(InqueryPNoticeListResult.PNotice_GetPNoticeByNationalityCode_NotFound);

            var thePNoticeContractList = thePNoticeList.Select(a => new PNoticeContract()
            {
                CreateDateTime     = a.CreateDateTime,
                No                 = a.No,
                NoticeDate         = a.NoticeDate,
                NoticePersonFamily = a.NoticePersonFamily,
                NoticePersonName   = a.NoticePersonName
            }
            ).ToList();

            return new PNoticeInqueryResponse
            {
                ThePNoticeContractList = new Page<List<PNoticeContract>> 
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

            var theStimulPNotice = this.GetPNoticeForStimul(thePNotice);

            return new ExportPNoticeResponse()
            {
                ThePNoticeExportContract = new PNoticeExportContract()
                {
                    Pdf = PunishmentOrgConstants.PNotice.PNoticePrint.ExportPdf("PNotice", theStimulPNotice) 
                },
                Result = AnuResult.Successful.GetResult()
            };
        }

        private PNoticeForStimul GetPNoticeForStimul(PNotice thePNotice)
        {
            PNoticeForStimul thePNoticeForStimul = new PNoticeForStimul()
            {
                NoticeCreateDate = thePNotice.CreateDateTime.Substring(0, 10),
                NoticeNo         = thePNotice.No,
                UnitName         = thePNotice.TheUnit?.UnitName,
                Address          = thePNotice.NoticePersonAddress,
                NoticeType       = thePNotice.TheGNoticeType?.Title,
                PersonAddress    = thePNotice.TheUnit.Address,
                NoticeDate       = thePNotice.NoticeDate ?? CalendarHelper.GetCurrentDate(),
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
                    break;
                }
                if (PNoticePerson.TheExpertMan != null)
                {
                    thePNoticeForStimul.PersonName         = PNoticePerson.TheExpertMan.Name;
                    thePNoticeForStimul.PersonFamily       = PNoticePerson.TheExpertMan.Family;
                    thePNoticeForStimul.PersonFatherName   = PNoticePerson.TheExpertMan.FatherName;
                    thePNoticeForStimul.PersonNationalCode = PNoticePerson.TheExpertMan.NationalityCode;
                    thePNoticeForStimul.PhoneNumber        = PNoticePerson.TheExpertMan.Tel;
                    thePNoticeForStimul.MobilNumber        = PNoticePerson.TheExpertMan.MobileNumber4SMS;
                    break;
                }
            }

            //bool hasJudgment = thePNotice.ThePNoticeDocList.Any(x => x.TheSystemObject.Code == );

            thePNoticeForStimul.Description = thePNotice.Description.StripRichTextFormat();
            if (thePNotice.InputStatistic != null)
            {
                thePNoticeForStimul.presenceTime = thePNotice.InputStatistic + " روز پس از رویت";
            }
            if (thePNotice.PresenceDate != null)
            {
                thePNoticeForStimul.presenceTime = "در تاریخ " + thePNotice.PresenceDate + " در ساعت " + thePNotice.PresenceTime;
            }
            if (thePNotice.ThePNoticePersonList.Count > 0)
            {
                int counter = 0;
                foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
                {
                    counter++;
                    var RelatedCaseNo = onePNoticePerson.ThePCase.No;
                    thePNoticeForStimul.CaseNo += RelatedCaseNo;
                    if (thePNotice.ThePNoticePersonList.Count > 1 && counter < thePNotice.ThePNoticePersonList.Count)
                    {
                        thePNoticeForStimul.CaseNo += " و ";
                    }
                }
            }
            if (thePNoticeForStimul.CaseNo == null)
            {
                thePNoticeForStimul.CaseNo = "";
            }

            if (thePNotice.ThePNoticePersonList.Count > 0)
            {
                int counter = 0;
                foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
                {
                    counter++;
                    var ANo = onePNoticePerson.ThePCase.ArchiveNo;
                    thePNoticeForStimul.CaseArchiveNo += ANo;
                    if (thePNotice.ThePNoticePersonList.Count > 1 && counter < thePNotice.ThePNoticePersonList.Count)
                    {
                        thePNoticeForStimul.CaseArchiveNo += " و ";
                    }
                }
            }
            if (thePNoticeForStimul.CaseArchiveNo == null)
            {
                thePNoticeForStimul.CaseArchiveNo = "";
            }
            Collection<PBViolationType> HashViolation = new Collection<PBViolationType>();

            //foreach (PNoticePerson onePNoticePerson in thePNotice.ThePNoticePersonList)
            //{
            //    if (onePNoticePerson.ThePCasePerson != null)
            //        foreach (PCaseViolation item in onePNoticePerson.ThePCasePerson.PersonViolationList)
            //        {
            //            if (!string.IsNullOrEmpty(item.ObjectId) && !HashViolation.Contains(item.ThePBViolationType))
            //                HashViolation.Add(item.ThePBViolationType);
            //        }
            //}

            string Violation = "";
            int counter1 = 0;
            //todo
            foreach (PBViolationType item in HashViolation)
            {

                counter1++;
                Violation = item.Title;
                thePNoticeForStimul.Violation += Violation;
                if (HashViolation.Count > 1 && counter1 < HashViolation.Count)
                {
                    thePNoticeForStimul.Violation += " و ";
                }
            }
            if (thePNoticeForStimul.Violation == null)
            {
                thePNoticeForStimul.Violation = "";
            }
            foreach (PNoticePerson item in thePNotice.ThePNoticePersonList)
            {
                if (item.ThePCasePerson != null)
                {
                    if (item.ThePCasePerson.PersonType == PersonType.NaturalPerson)
                        thePNoticeForStimul.PersonType = "مشخصات ابلاغ شونده حقیقی";
                    else if (item.ThePCasePerson.PersonType == PersonType.Legal)
                        thePNoticeForStimul.PersonType = "مشخصات ابلاغ شونده حقوقی";
                }
                else
                    thePNoticeForStimul.PersonType = "";
            }
            return thePNoticeForStimul;
        }
        #endregion Overrides

        #region Methods

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