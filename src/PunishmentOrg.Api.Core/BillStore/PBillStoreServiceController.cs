
using Anu.BaseInfo.DataAccess.SystemObject;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.DataAccess.BaseInfo;
using Anu.PunishmentOrg.DataAccess.DiscoveryMinutes;
using Anu.PunishmentOrg.DataAccess.PBillStore;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.DataModel.BillStore;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Anu.PunishmentOrg.Domain.DiscoveryMinutes;
using Anu.PunishmentOrg.Domain.PBillStore;
using Anu.PunishmentOrg.ServiceModel.BillStore;

using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;
using static Anu.Constants.ServiceModel.PunishmentOrg.PunishmentOrgConstants;

namespace Anu.PunishmentOrg.Api.BillStore
{
    public class PBillStoreServiceController : PBillStoreServiceControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;


        #region Constructor
        public PBillStoreServiceController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }




        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides

        public async override Task<PBillStoreServiceResponse> ReceivePBillStoreFromScms([FromBody] PBillStoreServiceRequest request)
        {
            var receivePBillStoreFromScmsResponse = new PBillStoreServiceResponse()
            {
                UniqueNo = "-1"
            };

            try
            {

                await LoginValidation.ValidateLoginAsync(request.Request, PunishmentOrgConstants.GFESUserAccessType.SendPBillStoreService, _unitOfWork);

                //TODO: Add bill number(max:32) and date(max:12?) length validation

                if (IsDuplicateEntry(request))
                {
                    return Respond(PBillStoreResult.PBillStore_Duplicate_Bill);
                }

                if (IsProductListEmpty(request))
                {
                    return Respond(PBillStoreResult.PBillStore_NoProductListProvided);
                }

                PBillStore pBillStore = new()
                {
                    Id = new Guid().ToString()[..31],
                    Timestamp = 1,
                    BillDate = request.BillDate,
                    BillNo = request.BillNumber,
                    CreateDateTime = CalendarHelper.GetCurrentDateTime(),
                    PCaseNo = request.ParentContentNumber,
                    UniqueNo = Utility.Utility.GetRandomNumber(Anu.Constants.ServiceModel.General.GeneralConstants.ConventionalConstants.UniqueNumberLength)
                };

                //var pDiscoveryMinutes = await _unitOfWork.PDiscoveryMinutes.GetPDiscoveryMinutesByUniqueNo(request.ProceedingNumber);
                var pDiscoveryMinutes = await _unitOfWork.Repositorey<PDiscoveryMinutesRepository>().GetPDiscoveryMinutesByUniqueNo(request.ProceedingNumber);
                pBillStore.ThePDiscoveryMinutes = (pDiscoveryMinutes is null) ? null : pDiscoveryMinutes;

                pBillStore.TheObjectState = _unitOfWork.Repositorey<ObjectStateRepository>().GetById(PunishmentOrgObjectState.PBillStore.Confirm);

                pBillStore.TheDiscoveryOrg = GetDiscoveryOrganization(request.CodingDeviceDetector);
                pBillStore.id_shenaseResid = request.TrackingCodeStores;


                var transfereeStringBuilder = new StringBuilder();
                var deliveryStringBuilder = new StringBuilder();

                foreach (var person in request.ThePBillStorePersonScmsList)
                {
                    var personName = person.Fname + " " + person.Lname + "-" + person.NationalCode + ",";

                    if (person.RoleNameEN == nameof(PersonRole.Transferee))
                    {
                        transfereeStringBuilder.Append(personName);
                    }
                    else
                    {
                        deliveryStringBuilder.Append(personName);
                    }
                }

                pBillStore.TransfereeName = transfereeStringBuilder.ToString();
                pBillStore.TransfereeFamily = transfereeStringBuilder.ToString();

                pBillStore.DeliveryName = deliveryStringBuilder.ToString();
                pBillStore.DeliveryFamily = deliveryStringBuilder.ToString();



                pBillStore.ThePBillStoreProductList = new();
                int rowNumber = 1;
                foreach (var product in request.ThePBillStoreProductList)
                {
                    var pBillStoreProduct = new PBillStoreProduct()
                    {
                        Id = new Guid().ToString()[..31],
                        Timestamp = 1,
                        RowNumber = rowNumber,
                        IDNumber = product.IDNumber, //previously was Cid_Code
                        ProductTitle = product.ProductTitle, //previously was Goods_Name
                        ProductDesc = product.ProductDesc, //previously was Good_Desc
                        PackingType = product.PackingType //previously was Package_Type
                    };

                    rowNumber++;
                    pBillStore.ThePBillStoreProductList.Add(pBillStoreProduct);
                }

                _unitOfWork.Repositorey<PBillStoreRepository>().Add(pBillStore);
                _unitOfWork.Complete();

                return Respond(AnuResult.Successful, pBillStore.UniqueNo);
            }
            catch (AnuExceptions ex)
            {
                receivePBillStoreFromScmsResponse.Result = ex.result;
                return receivePBillStoreFromScmsResponse;
            }
            catch (Exception ex)
            {
                return new PBillStoreServiceResponse() { Result = AnuResult.Error.GetResult(ex) };
            }
        }


        //[Authentication.Permission("SendPBillStore")]
        public override PBillStoreServiceResponse SendPBillStore([FromBody] PBillStoreServiceRequest request)
        {
            throw new NotImplementedException();
        }


        #endregion Overrides


        #region Methods


        private PBillStoreServiceResponse Respond(PBillStoreResult result)
        {
            var response = new PBillStoreServiceResponse() { Result = result.GetResult() };
            return response;
        }
        private PBillStoreServiceResponse Respond(AnuResult result, string uniqueNumber = "-1")
        {
            var response = new PBillStoreServiceResponse()
            {
                Result = result.GetResult(),
                UniqueNo = uniqueNumber
            };
            return response;
        }

        private bool IsProductListEmpty(PBillStoreServiceRequest request)
        {
            return request.ThePBillStoreProductList is null || request.ThePBillStoreProductList.Count.Equals(0);
        }

        private bool IsDuplicateEntry(PBillStoreServiceRequest request)
        {
            var isDuplicate = false;

            var billEntity = _unitOfWork.Repositorey<PBillStoreRepository>().GetByNumberDate(request.BillNumber, request.BillDate);

            if (billEntity.Result.Count() != 0)
            {
                isDuplicate = true;
            }

            return isDuplicate;
        }

        private PBExchangeUnit GetDiscoveryOrganization(string organizationCode)
        {
            string organizationId = string.Empty;

            switch (organizationCode)
            {
                case nameof(PunishmentOrgConstants.NajaUnitCode.ConsumerProtection):
                    organizationId = PunishmentOrgConstants.NajaUnit.ConsumerProtection;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.Customs):
                    organizationId = PunishmentOrgConstants.NajaUnit.Customs;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.InformationMinistry):
                    organizationId = PunishmentOrgConstants.NajaUnit.InformationMinistry;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.Irgc):
                    organizationId = PunishmentOrgConstants.NajaUnit.Irgc;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.Naja):
                    organizationId = PunishmentOrgConstants.NajaUnit.Naja;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.AgricultureMinistry):
                    organizationId = PunishmentOrgConstants.NajaUnit.AgricultureMinistry;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.FisheriesOrganization):
                    organizationId = PunishmentOrgConstants.NajaUnit.FisheriesOrganization;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.ForestsOrganization):
                    organizationId = PunishmentOrgConstants.NajaUnit.ForestsOrganization;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.OilCompany):
                    organizationId = PunishmentOrgConstants.NajaUnit.OilCompany;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.CulturalHeritageMinistry):
                    organizationId = PunishmentOrgConstants.NajaUnit.CulturalHeritageMinistry;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.EnvironmentalProtectionOrganization):
                    organizationId = PunishmentOrgConstants.NajaUnit.EnvironmentalProtectionOrganization;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.CentralBank):
                    organizationId = PunishmentOrgConstants.NajaUnit.CentralBank;
                    break;

                case nameof(PunishmentOrgConstants.NajaUnitCode.FoodDrugOrganization):
                    organizationId = PunishmentOrgConstants.NajaUnit.FoodDrugOrganization;
                    break;

            }
            return _unitOfWork.Repositorey<PBExchangeUnitRepository>().GetById(organizationId);
        }


        #endregion Methods
    }
}