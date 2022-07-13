using Anu.Commons.ServiceModel.ServiceResponse;
using Anu.Commons.Validations;
using Anu.PunishmentOrg.DataModel.BaseInfo;
using Anu.PunishmentOrg.DataModel.BillStore;
using Anu.PunishmentOrg.ServiceBase;
using Anu.PunishmentOrg.ServiceModel.ServiceRequest;
using Anu.PunishmentOrg.ServiceModel.ServiceResponse;
using Microsoft.AspNetCore.Mvc;
using ServiceModel.Constants;
using System.Text;
using Utility.CalendarHelper;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Service;

public class PBillStoreController : IPBillStoreBase
{
    public PBillStoreController(Anu.DataAccess.IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    [Route("api/pbill")]
    public override async Task<ReceivePBillStoreFromScmsResponse> ReceivePBillStoreFromScms([FromBody] ReceivePBillStoreFromScmsRequest request)
    {
        var receivePBillStoreFromScmsResponse = new ReceivePBillStoreFromScmsResponse()
        {
            UniqueNo = "-1"
        };

        try
        {

            await Login.ValidateLoginAsync(request.Request, GFESUserAccessType.SendPBillStoreService, _unitOfWork);

            if (IsDuplicateEntry(request))            
            {
                receivePBillStoreFromScmsResponse.Result = Utility.ResultUtility.getResult(ResultType.PBillStore_Duplicate_Bill);

                return receivePBillStoreFromScmsResponse;
            }
            

            PBillStore pBillStore = new()
            {
                BillDate = request.BillDate,
                BillNo = request.BillNumber,
                CreateDateTime = CalendarHelper.GetCurrentDateTime(),
                PCaseNo = request.ParentContentNumber,
                UniqueNo = Utility.Utility.GetRandomNumber(ConventionalConstants.UniqueNumberLength)
            };

            var pDiscoveryMinutes = await _unitOfWork.PDiscoveryMinutes.GetPDiscoveryMinutesByUniqueNo(request.ProceedingNumber);
            pBillStore.ThePDiscoveryMinutes = (pDiscoveryMinutes is null) ? null : pDiscoveryMinutes;

            pBillStore.TheObjectState = _unitOfWork.ObjectState.GetById(PunishmentOrgObjectState.PBillStore.Confirm);
            //InstanceBuilder.GetEntityById<IObjectState>(Anu.PunishmentOrg.ObjectStates.PBillStore.Confirm);

            //pBillStore.ThePDiscoveryMinutes = InstanceBuilder.GetEntityByCode<IPDiscoveryMinutes>(request.ProceedingNumber, PunishmentOrgQueryBase.PDiscoveryMinutes.UniqueNo);

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
                var pBillStoreProduct = new PBillStoreProduct();
                pBillStoreProduct.RowNumber = rowNumber;
                pBillStoreProduct.IDNumber = product.IDNumber; //previously was Cid_Code
                pBillStoreProduct.ProductTitle = product.ProductTitle; //previously was Goods_Name
                pBillStoreProduct.ProductDesc = product.ProductDesc; //previously was Good_Desc
                pBillStoreProduct.PackingType = product.PackingType; //previously was Package_Type

                rowNumber++;
                pBillStore.ThePBillStoreProductList.Add(pBillStoreProduct);
            }

            receivePBillStoreFromScmsResponse.Result = Utility.ResultUtility.getResult(ResultType.Successful);
            receivePBillStoreFromScmsResponse.UniqueNo = pBillStore.UniqueNo;

            return receivePBillStoreFromScmsResponse;
        }
        catch (AnuExceptions ex)
        {
            receivePBillStoreFromScmsResponse.Result = ex.result;
            return receivePBillStoreFromScmsResponse;
        }
    }

    private bool IsDuplicateEntry(ReceivePBillStoreFromScmsRequest request)
    {
        var isDuplicate = false;

        var billEntity = _unitOfWork.PBillStoreRepository.GetByNumberDate(request.BillNumber, request.BillDate);

        if (billEntity is null)
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
