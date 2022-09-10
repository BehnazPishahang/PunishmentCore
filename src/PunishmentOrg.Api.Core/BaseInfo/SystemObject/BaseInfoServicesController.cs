
using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.DataModel.Types;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.BaseInfo.Domain.Types;
using Anu.BaseInfo.ServiceModel.SystemObject;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations.BaseInfo.SystemObject;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Utility;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.BaseInfo.Api.SystemObject

{
    public class BaseInfoServicesController : BaseInfoServicesControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public BaseInfoServicesController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        bool AlreadyCommited = true;
        //[PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.SendBaseInfoServices)]
        [AllowAnonymous]
        public override async Task<SendBaseInfoResponse> SendBaseInfo([Microsoft.AspNetCore.Mvc.FromBody] SendBaseInfoRequest request)
        {
            var SendBaseInfoResponse = new SendBaseInfoResponse();
            try
            {
                #region Validation

                request.TheBaseInfoServiceContract?.Title.NullOrWhiteSpace(SystemObjectResult.BaseInfoServicesResult_Error_Title_Is_Required);
                request.TheBaseInfoServiceContract?.Code.NullOrWhiteSpace(SystemObjectResult.BaseInfoServicesResult_Error_Code_Is_Required);
                request.TheBaseInfoServiceContract?.Code.IsDigit(SystemObjectResult.BaseInfoServicesResult_Error_Code_Is_Not_Digit);
                request.TheBaseInfoServiceContract?.TheSystemObjectContract.Null(SystemObjectResult.BaseInfoServicesResult_Error_SystemObject_Code_Is_Required);
                request.TheBaseInfoServiceContract?.TheSystemObjectContract?.Code.NullOrWhiteSpace(SystemObjectResult.BaseInfoServicesResult_Error_SystemObject_Code_Is_Required);
                
                var theSystemObject = await _unitOfWork.Repositorey<ISystemObjectRepository>().GetSystemObjectByCode(request.TheBaseInfoServiceContract?.TheSystemObjectContract?.Code);
                
                if(theSystemObject.Null())
                {
                    return Respond(SystemObjectResult.BaseInfoServicesResult_Error_SystemObject_Code_Is_Not_Valid);
                }

                #endregion Validation

                #region Commit

                var typeName = theSystemObject.Select(x=>x.EnglishName).First().Split('.')[theSystemObject.Select(x => x.EnglishName).First().Split('.').Length - 1];

                switch (typeName)
                {
                    case "MeasurementUnitType":
                        if (!IsMeasurementUnitTypeExisted(request.TheBaseInfoServiceContract?.Code).Result)
                        {
                            SetNewMeasurementUnitType(request);
                        }
                        break;
                    case "PBProductCurrencyType":
                        if (!IsPBProductCurrencyTypeExisted(request.TheBaseInfoServiceContract?.Code).Result)
                        {
                            SetNewPBProductCurrencyType(request);
                        }
                        break;
                    case "GExchangeUnitTitle":
                        if (!IsGExchangeUnitTitleExisted(request.TheBaseInfoServiceContract?.Code).Result)
                        {
                            SetNewGExchangeUnitTitle(request);
                        }
                        break;
                }

                if (AlreadyCommited)
                {
                    return Respond(SystemObjectResult.BaseInfoServicesResult_Error_BaseInfoRecord_Already_Commited);
                }

                _unitOfWork.Complete();

                return Respond(AnuResult.Successful, request);

                #endregion Commit
            }
            catch (AnuExceptions ex)
            {
                SendBaseInfoResponse.Result = ex.result;
                return SendBaseInfoResponse;
            }
            catch (Exception ex)
            {
                SendBaseInfoResponse.Result = AnuResult.Error.GetResult(ex);
                return SendBaseInfoResponse;
            }
        }
        #endregion Overrides

        #region Methods
        private SendBaseInfoResponse Respond(SystemObjectResult result)
        {
            var response = new SendBaseInfoResponse()
            {
                Result = result.GetResult()
            };
            return response;
        }
        private SendBaseInfoResponse Respond(AnuResult result, SendBaseInfoRequest request)
        {
            var response = new SendBaseInfoResponse()
            {
                Result = result.GetResult(),
                TheBaseInfoServiceContract = new BaseInfoServiceContract() {

                    Code = request.TheBaseInfoServiceContract?.Code,
                    Title= request.TheBaseInfoServiceContract?.Title
                }
            };
            return response;
        }

        private async Task<bool> IsGExchangeUnitTitleExisted(string code)
        {
            var theGExchangeUnitTitle = await _unitOfWork.Repositorey<IGExchangeUnitTitleRepository>().GetByCode(code);
            if(theGExchangeUnitTitle == null)
            {
                AlreadyCommited = false;
            }
            return AlreadyCommited;
        }

        private async Task<bool> IsPBProductCurrencyTypeExisted(string code)
        {
            var thePBProductCurrencyType = await _unitOfWork.Repositorey<IPBProductCurrencyTypeRepository>().GetByCode(code);
            if (thePBProductCurrencyType == null)
            {
                AlreadyCommited = false;
            }
            return AlreadyCommited;
        }

        private async Task<bool> IsMeasurementUnitTypeExisted(string code)
        {
            var theMeasurementUnitType = await _unitOfWork.Repositorey<IMeasurementUnitTypeRepository>().GetByCode(code);
            if (theMeasurementUnitType == null)
            {
                AlreadyCommited = false;
            }
            return AlreadyCommited;
        }

        private async void SetNewGExchangeUnitTitle(SendBaseInfoRequest request)
        {
            GExchangeUnitTitle oneGExchangeUnitTitle = new GExchangeUnitTitle()
            {
                Id                  = Guid.NewGuid().ToString("N"),
                Code                = request.TheBaseInfoServiceContract?.Code,
                Title               = request.TheBaseInfoServiceContract?.Title,
                IsMechanizeRelation = Enumerations.YesNo.No,
                State               = Enumerations.State.Valid
            };
            await _unitOfWork.Repositorey<IGExchangeUnitTitleRepository>().Add(oneGExchangeUnitTitle);
        }

        private async void SetNewPBProductCurrencyType(SendBaseInfoRequest request)
        {
            PBProductCurrencyType onePBProductCurrencyType = new PBProductCurrencyType()
            {
                Id              = Guid.NewGuid().ToString("N"),
                Code            = request.TheBaseInfoServiceContract?.Code,
                Title           = request.TheBaseInfoServiceContract?.Title,
                State           = PunishmentOrg.Enumerations.PULegalPersonState.active,
                ProductCurrency = PunishmentOrg.Enumerations.PUProductCurrency.Product,
                LevelCode       = GetLevelCode(PunishmentOrg.Enumerations.PUProductCurrency.Product).Result
            };
            await _unitOfWork.Repositorey<IPBProductCurrencyTypeRepository>().Add(onePBProductCurrencyType);
        }

        private async void SetNewMeasurementUnitType(SendBaseInfoRequest request)
        {
            MeasurementUnitType oneMeasurementUnitType = new MeasurementUnitType()
            {
                Id          = Guid.NewGuid().ToString("N"),
                Code        = request.TheBaseInfoServiceContract?.Code,
                Title       = request.TheBaseInfoServiceContract?.Title,
                State       = Enumerations.State.Valid,
                OverallType = Enumerations.MeasurementUnitType.Other
            };
            await _unitOfWork.Repositorey<IMeasurementUnitTypeRepository>().Add(oneMeasurementUnitType);
        }

        private async Task<string> GetLevelCode(PunishmentOrg.Enumerations.PUProductCurrency ProductCurrency)
        {
            int product_currency = (int)ProductCurrency;
            var MaxLevelCode     = await _unitOfWork.Repositorey<IPBProductCurrencyTypeRepository>().GetMaxLevelCode(product_currency.ToString());

            if (MaxLevelCode.NullOrWhiteSpace())
            {
                return product_currency + "00001";
            }
            else
            {
                int val = (int.Parse((MaxLevelCode).Substring((MaxLevelCode).Length - 5, 5)));
                val++;
                return product_currency + val.ToString().PadLeft(5, '0');
            }
        }
        #endregion Methods
    }
}