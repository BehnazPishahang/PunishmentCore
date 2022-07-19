using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Commons.Validations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.DataModel.BillStore;
using Anu.PunishmentOrg.ServiceBase;
using Anu.PunishmentOrg.ServiceModel.ServiceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceResponse;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Utility;
using Utility.CalendarHelper;
using Utility.Exceptions;

namespace Anu.PunishmentOrg.Service;

public class PBillStoreController : ServiceBase.PBillStoreBase
{
    public PBillStoreController(Anu.DataAccess.IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }


    public override async Task<ReceivePBillStoreFromScmsResponse> ReceivePBillStoreFromScms([FromBody] ReceivePBillStoreFromScmsRequest request)
    {
        var receivePBillStoreFromScmsResponse = new ReceivePBillStoreFromScmsResponse()
        {
            UniqueNo = "-1"
        };

        try
        {

            await Login.ValidateLoginAsync(request.Request, GFESUserAccessType.SendPBillStoreService, _unitOfWork);

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

            var pDiscoveryMinutes = await _unitOfWork.PDiscoveryMinutes.GetPDiscoveryMinutesByUniqueNo(request.ProceedingNumber);
            pBillStore.ThePDiscoveryMinutes = (pDiscoveryMinutes is null) ? null : pDiscoveryMinutes;

            pBillStore.TheObjectState = _unitOfWork.ObjectState.GetById(PunishmentOrgObjectState.PBillStore.Confirm);

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

            _unitOfWork.PBillStoreRepository.Add(pBillStore);
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
            return new ReceivePBillStoreFromScmsResponse() { Result = AnuResult.Error.GetResult(ex) };
        }

    }

    private ReceivePBillStoreFromScmsResponse Respond(PBillStoreResult result)
    {
        var response = new ReceivePBillStoreFromScmsResponse() { Result = result.GetResult() };
        return response;
    }
    private ReceivePBillStoreFromScmsResponse Respond(AnuResult result, string uniqueNumber = "-1")
    {
        var response = new ReceivePBillStoreFromScmsResponse()
        {
            Result = result.GetResult(),
            UniqueNo = uniqueNumber
        };
        return response;
    }
   
    private bool IsProductListEmpty(ReceivePBillStoreFromScmsRequest request)
    {
        return request.ThePBillStoreProductList is null || request.ThePBillStoreProductList.Count.Equals(0);
    }

    private bool IsDuplicateEntry(ReceivePBillStoreFromScmsRequest request)
    {
        var isDuplicate = false;

        var billEntity = _unitOfWork.PBillStoreRepository.GetByNumberDate(request.BillNumber, request.BillDate);

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
            case nameof(NajaUnitCode.ConsumerProtection):
                organizationId = NajaUnit.ConsumerProtection;
                break;

            case nameof(NajaUnitCode.Customs):
                organizationId = NajaUnit.Customs;
                break;

            case nameof(NajaUnitCode.InformationMinistry):
                organizationId = NajaUnit.InformationMinistry;
                break;

            case nameof(NajaUnitCode.Irgc):
                organizationId = NajaUnit.Irgc;
                break;

            case nameof(NajaUnitCode.Naja):
                organizationId = NajaUnit.Naja;
                break;

            case nameof(NajaUnitCode.AgricultureMinistry):
                organizationId = NajaUnit.AgricultureMinistry;
                break;

            case nameof(NajaUnitCode.FisheriesOrganization):
                organizationId = NajaUnit.FisheriesOrganization;
                break;

            case nameof(NajaUnitCode.ForestsOrganization):
                organizationId = NajaUnit.ForestsOrganization;
                break;

            case nameof(NajaUnitCode.OilCompany):
                organizationId = NajaUnit.OilCompany;
                break;

            case nameof(NajaUnitCode.CulturalHeritageMinistry):
                organizationId = NajaUnit.CulturalHeritageMinistry;
                break;

            case nameof(NajaUnitCode.EnvironmentalProtectionOrganization):
                organizationId = NajaUnit.EnvironmentalProtectionOrganization;
                break;

            case nameof(NajaUnitCode.CentralBank):
                organizationId = NajaUnit.CentralBank;
                break;

            case nameof(NajaUnitCode.FoodDrugOrganization):
                organizationId = NajaUnit.FoodDrugOrganization;
                break;

        }
        return _unitOfWork.PBExchangeUnitRepository.GetById(organizationId);
    }
}
