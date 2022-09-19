using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.Domain.Case;
using Anu.PunishmentOrg.ServiceModel.Case;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Anu.Report;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Case
{

    public class PCaseServiceController : PCaseServiceControllerBase
    {

        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        public PCaseServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        //[Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<ExportInqueryPCaseResponse> ExportInqueryPCase([FromBody] ExportInqueryPCaseRequest request)
        {
            request.Null(AnuResult.In_Valid_Input);

            request.ExportInqueryPCaseInputContract.NationalCode.Null(AnuResult.NationalCode_Is_Not_Entered);
            request.ExportInqueryPCaseInputContract.No.Null(PCaseResult.No_Is_Not_Entered);

            request.ExportInqueryPCaseInputContract.No.IsDigit(PCaseResult.No_Is_Not_Entered);
            request.ExportInqueryPCaseInputContract.NationalCode.IsValidNationalCode();

            var cases = await _unitOfWork.Repositorey<IPCaseRepository>().ExportInqueryPCase(
                request.ExportInqueryPCaseInputContract.NationalCode, request.ExportInqueryPCaseInputContract.No);
            cases.Null(PCaseResult.You_Do_Not_Have_Any_Case);

            //Stimul Text = new Stimul(){Text=text ,
            //    No="شماره پرونده :"+request.ExportInqueryPCaseInputContract.No
            //};

            return new ExportInqueryPCaseResponse
            {
                Result = AnuResult.Successful.GetResult(),
                ExportInqueryPCaseContract = new ExportInqueryPCaseContract()
                {
                    No = request.ExportInqueryPCaseInputContract.No,
                    Cases = (List<List<string>>)cases
                }
            };


        }

        //[PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<GetAllPCaseResponse> GetAllPCase([FromBody] GetAllPCaseRequest request)
        {
            request.Null(AnuResult.In_Valid_Input);

            request.GetAllPCaseInputContract.NationalCode.Null(AnuResult.NationalCode_Is_Not_Entered);
            request.GetAllPCaseInputContract.NationalCode.IsValidNationalCode();

            if (request.GetAllPCaseInputContract.CaseArchiveState != Enumerations.PUCaseArchiveState.Active && 
                request.GetAllPCaseInputContract.CaseArchiveState != Enumerations.PUCaseArchiveState.Closed && 
                request.GetAllPCaseInputContract.CaseArchiveState != Enumerations.PUCaseArchiveState.None)
            {
                return new GetAllPCaseResponse() { Result = PCaseResult.CaseState_Is_Not_Valid.GetResult() };
            }


            var pCase = await _unitOfWork.Repositorey<IPCaseRepository>().GetAllPCaseWithNationalCode(
                request.GetAllPCaseInputContract.NationalCode, request.GetAllPCaseInputContract.CaseArchiveState);
            pCase.Null(PCaseResult.You_Do_Not_Have_Any_Case);

            var theGetAllPCaseContract = pCase.Select(a => new GetAllPCaseContract()
            {
                No = a.No,
                CreateDateTime = a.CreateDateTime.Substring(0,10),
                UnitName = a.TheHandlerUnit.UnitName,
                CaseArchiveState = a.CaseArchiveState
            }).ToList();

            return new GetAllPCaseResponse
            {
                Result = AnuResult.Successful.GetResult(),
                GetAllPCaseContract = theGetAllPCaseContract
            };

        }


        [PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.Tazirat135Users)]
        //[Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public override async Task<GetStatisticPCaseResponse> GetStatisticPCase([FromBody] GetStatisticPCaseRequest request)
        {
            request.Null(AnuResult.In_Valid_Input);

            request.GetStatisticPCaseInputContract.NationalCode.Null(AnuResult.NationalCode_Is_Not_Entered);

            request.GetStatisticPCaseInputContract.NationalCode.IsValidNationalCode();

            var statistic = await _unitOfWork.Repositorey<IPCaseRepository>().GetStatistic(
                request.GetStatisticPCaseInputContract.NationalCode);

            return new GetStatisticPCaseResponse
            {
                Result = AnuResult.Successful.GetResult(),
                StatisticContract = new Commons.ServiceModel.ServiceStatisticResponse.StatisticContract()
                {
                    CountSeen = statistic.CountSeen,
                    CountTotal = statistic.CountTotal,
                    CountUnSeen = statistic.CountUnSeen
                }
            };
        }
    }

    internal class Stimul
    {
        public string Text { get; set; }
        public string No { get; set; }
    }
}
