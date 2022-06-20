
using Microsoft.AspNetCore.Mvc;
using PunishmentOrg.Domain.Interface;
using ServiceModel.Commons.ServiceResponse;
using ServiceModel.Constants;
using ServiceRequest.Anu.PunishmentOrg;
using ServiceResponse.Anu.PunishmentOrg;
using Utility.Exceptions;
using Utility.Guard;
using Validations.Commons;

namespace PunishmentOrg.Api.Core.Service.Anu.PunishmentOrg
{

    public class PDiscoveryMinutesController : ServiceBase.Anu.PunishmentOrg.IPDiscoveryMinutesBase
    {
        public PDiscoveryMinutesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //[HttpGet(Name = "PDiscoveryMinutes/{UniqueNo}")]
        //public async Task<string> PDiscoveryMinutesAsync(string UniqueNo)
        //{
        //    await Task.Delay(1);
        //    //var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
        //    //string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

        //    var byParentCode = _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(UniqueNo);
        //    var byNO = _unitOfWork.PCaseRepository.GetTerminateCaseByNo("");

        //    _unitOfWork.Complete();


        //    return "";
        //}

        public override async Task<Result> PDiscovery(string No)
        {
            try
            {
                No = null;
                No.Null(ResultType.Error);


                var pDiscovery = await _unitOfWork.PDiscoveryMinutes.getObejectStateTitleWithUniqueNo(No);
                string title = pDiscovery.FirstOrDefault().TheObjectState.Title.ToString();

                _unitOfWork.Complete();


                return new Result { Code = ResultType.Successful.ToString(), Message = title };
            }
            catch (AnuExceptions ex)
            {
                return ex.result;
            }
        }

        public override async Task<SendPDiscoveryMinutesStateResponse> SendPDiscoveryMinutesState([FromBody] SendPDiscoveryMinutesStateRequest request)
        {
            try
            {
                await Login.ValidateLoginAsync(request.Request, GFESUserAccessType.SendPDiscoveryMinute, _unitOfWork);

                request.UnitNo.IsDigit(ResultType.Error_UniqueNo_Is_Required);
                request.UnitNo.NullOrWhiteSpace(ResultType.Error_UniqueNo_Is_Required);



                return null;
            }
            catch (AnuExceptions ex)
            {
                return new SendPDiscoveryMinutesStateResponse { Result= ex.result };
            }

        }
    }
}
